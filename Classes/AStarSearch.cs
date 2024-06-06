using org.ogre;

namespace MyOgreProgram.Classes
{
    public class MyOgreLevelNode
    {

        public MyOgreLevelNode? parent; // used during the search to record the parent of successor nodes
        public MyOgreLevelNode? child; // used after the search for the application to view the search in reverse

        public float g; // cost of this node + it's predecessors
        public float h; // heuristic estimate of distance to goal
        public float f; // sum of cumulative cost of predecessors and self and heuristic

        public MyOgreLevelNode()
        {
            parent = null;
            child = null;
            g = 0.0f;
            h = 0.0f;
            f = 0.0f;
            //        parent( 0 ),
            //		child( 0 ),
            //		g( 0.0f ),
            //		h( 0.0f ),
            //		f( 0.0f )

        }

        public MyLevelSearchNode m_UserState;
    }




    public class AStarSearch
    {
        public uint SEARCH_STATE_NOT_INITIALISED = 0;
        public uint SEARCH_STATE_SEARCHING = 1;
        public uint SEARCH_STATE_SUCCEEDED = 2;
        public uint SEARCH_STATE_FAILED = 3;
        public uint SEARCH_STATE_OUT_OF_MEMORY = 4;
        public uint SEARCH_STATE_INVALID = 5;

        // Heap (simple vector but used as a heap, cf. Steve Rabin's game gems article)
        public List<MyOgreLevelNode> m_OpenList;

        // Closed list is a std::vector.
        public List<MyOgreLevelNode> m_ClosedList;

        // Successors is a std::vector filled out by the user each type successors to a node
        // are generated
        public List<MyOgreLevelNode> m_Successors;

        // State
        public uint m_State;

        // Counts steps
        public int m_Steps;

        // Start and goal state pointers
        MyOgreLevelNode m_Start;
        MyOgreLevelNode m_Goal;

        MyOgreLevelNode m_CurrentSolutionNode;


        //Debug : need to keep these two iterators around
        // for the user Dbg functions
        MyOgreLevelNode iterDbgOpen;
        MyOgreLevelNode iterDbgClosed;

        // debugging : count memory allocation and free's
        int m_AllocateNodeCount;

        bool m_CancelRequest;
        // Get start node
        public MyLevelSearchNode? GetSolutionStart()
        {
            m_CurrentSolutionNode = m_Start;
            if (m_Start != null)
            {
                return m_Start.m_UserState;
            }
            else
            {
                return null;
            }
        }
        // Get next node
        public MyLevelSearchNode? GetSolutionNext()
        {
            if (m_CurrentSolutionNode != null)
            {
                if (m_CurrentSolutionNode.child != null)
                {

                    MyOgreLevelNode child = m_CurrentSolutionNode.child;

                    m_CurrentSolutionNode = m_CurrentSolutionNode.child;

                    return child.m_UserState;
                }
            }

            return null;
        }

        // Set Start and goal states
        internal void SetStartAndGoalStates(MyLevelSearchNode Start, MyLevelSearchNode Goal)
        {
            m_CancelRequest = false;

            m_Start = AllocateNode();
            m_Goal = AllocateNode();

            // assert((m_Start != NULL && m_Goal != NULL));

            m_Start.m_UserState = Start;
            m_Goal.m_UserState = Goal;

            m_State = SEARCH_STATE_SEARCHING;

            // Initialise the AStar specific parts of the Start Node
            // The user only needs fill out the state information

            m_Start.g = 0;
            m_Start.h = m_Start.m_UserState.GoalDistanceEstimate(m_Goal.m_UserState);
            m_Start.f = m_Start.g + m_Start.h;
            m_Start.parent = null;

            // Push the start node on the Open list

            m_OpenList.Add(m_Start); // heap now unsorted

            // Sort back element into heap
            m_OpenList = m_OpenList.OrderByDescending(x => x.f ).ToList();

            // Initialise counter for search steps
            m_Steps = 0;
        }

        // Node memory management
        private MyOgreLevelNode AllocateNode()
        {
            m_AllocateNodeCount++;
            MyOgreLevelNode p = new MyOgreLevelNode();
            return p;
        }

        public bool AddSuccessor(MyLevelSearchNode State )
        {
            MyOgreLevelNode node = AllocateNode();

            if (node!=null)
            {
                node.m_UserState = State;

                m_Successors.Add(node);

                return true;
            }

            return false;
        }

        public uint SearchStep()
        {
            // Firstly break if the user has not initialised the search
            if ((m_State > SEARCH_STATE_NOT_INITIALISED) && (m_State < SEARCH_STATE_INVALID)) throw new Exception("111");

            // Next I want it to be safe to do a searchstep once the search has succeeded...
            if ((m_State == SEARCH_STATE_SUCCEEDED) ||
                (m_State == SEARCH_STATE_FAILED)
              )
            {
                return m_State;
            }

            // Failure is defined as emptying the open list as there is nothing left to 
            // search...
            // New: Allow user abort
            if (m_OpenList.Count()<=0 || m_CancelRequest)
            {
                FreeAllNodes();
                m_State = SEARCH_STATE_FAILED;
                return m_State;
            }

            // Incremement step count
            m_Steps++;

            // Pop the best node (the one with the lowest f) 
            MyOgreLevelNode n = m_OpenList.First(); // get pointer to the node
  /*          pop_heap(m_OpenList.begin(), m_OpenList.end(), HeapCompare_f());
            m_OpenList.pop_back();

            // Check for the goal, once we pop that we're done
            if (n.m_UserState.IsGoal(m_Goal.m_UserState))
            {
                // The user is going to use the Goal Node he passed in 
                // so copy the parent pointer of n 
                m_Goal.parent = n.parent;

                // A special case is that the goal was passed in as the start state
                // so handle that here
                if (false == n.m_UserState.IsSameState(m_Start.m_UserState))
                {
                    FreeNode(n);

                    // set the child pointers in each node (except Goal which has no child)
                    MyOgreLevelNode nodeChild = m_Goal;
                    MyOgreLevelNode nodeParent = m_Goal.parent;

                    do
                    {
                        nodeParent.child = nodeChild;

                        nodeChild = nodeParent;
                        nodeParent = nodeParent.parent;

                    }
                    while (nodeChild != m_Start); // Start is always the first node by definition

                }

                // delete nodes that aren't needed for the solution
                FreeUnusedNodes();

                m_State = SEARCH_STATE_SUCCEEDED;

                return m_State;
            }
            else // not goal
            {

                // We now need to generate the successors of this node
                // The user helps us to do this, and we keep the new nodes in
                // m_Successors ...

                m_Successors.clear(); // empty vector of successor nodes to n

                // User provides this functions and uses AddSuccessor to add each successor of
                // node 'n' to m_Successors
                bool ret = n->m_UserState.GetSuccessors(this, n->parent ? &n->parent->m_UserState : NULL);

                if (!ret)
                {

                    typename vector<Node * >::iterator successor;

                    // free the nodes that may previously have been added 
                    for (successor = m_Successors.begin(); successor != m_Successors.end(); successor++)
                    {
                        FreeNode((*successor));
                    }

                    m_Successors.clear(); // empty vector of successor nodes to n

                    // free up everything else we allocated
                    FreeAllNodes();

                    m_State = SEARCH_STATE_OUT_OF_MEMORY;
                    return m_State;
                }

                // Now handle each successor to the current node ...
                for (typename vector< Node * >::iterator successor = m_Successors.begin(); successor != m_Successors.end(); successor++ )
			{

                    // 	The g value for this successor ...
                    float newg = n->g + n->m_UserState.GetCost((*successor)->m_UserState);

                    // Now we need to find whether the node is on the open or closed lists
                    // If it is but the node that is already on them is better (lower g)
                    // then we can forget about this successor

                    // First linear search of open list to find node

                    typename vector<Node * >::iterator openlist_result;

                    for (openlist_result = m_OpenList.begin(); openlist_result != m_OpenList.end(); openlist_result++)
                    {
                        if ((*openlist_result)->m_UserState.IsSameState((*successor)->m_UserState))
                        {
                            break;
                        }
                    }

                    if (openlist_result != m_OpenList.end())
                    {

                        // we found this state on open

                        if ((*openlist_result)->g <= newg)
                        {
                            FreeNode((*successor));

                            // the one on Open is cheaper than this one
                            continue;
                        }
                    }

                    typename vector<Node * >::iterator closedlist_result;

                    for (closedlist_result = m_ClosedList.begin(); closedlist_result != m_ClosedList.end(); closedlist_result++)
                    {
                        if ((*closedlist_result)->m_UserState.IsSameState((*successor)->m_UserState))
                        {
                            break;
                        }
                    }

                    if (closedlist_result != m_ClosedList.end())
                    {

                        // we found this state on closed

                        if ((*closedlist_result)->g <= newg)
                        {
                            // the one on Closed is cheaper than this one
                            FreeNode((*successor));

                            continue;
                        }
                    }

                // This node is the best node so far with this particular state
                // so lets keep it and set up its AStar specific data ...

                (*successor)->parent = n;
                    (*successor)->g = newg;
                    (*successor)->h = (*successor)->m_UserState.GoalDistanceEstimate(m_Goal->m_UserState);
                    (*successor)->f = (*successor)->g + (*successor)->h;

                    // Remove successor from closed if it was on it

                    if (closedlist_result != m_ClosedList.end())
                    {
                        // remove it from Closed
                        FreeNode((*closedlist_result));
                        m_ClosedList.erase(closedlist_result);

                        // Fix thanks to ...
                        // Greg Douglas <gregdouglasmail@gmail.com>
                        // who noticed that this code path was incorrect
                        // Here we have found a new state which is already CLOSED
                        // anus

                    }

                    // Update old version of this node
                    if (openlist_result != m_OpenList.end())
                    {

                        FreeNode((*openlist_result));
                        m_OpenList.erase(openlist_result);

                        // re-make the heap 
                        // make_heap rather than sort_heap is an essential bug fix
                        // thanks to Mike Ryynanen for pointing this out and then explaining
                        // it in detail. sort_heap called on an invalid heap does not work
                        make_heap(m_OpenList.begin(), m_OpenList.end(), HeapCompare_f());

                    }

                    // heap now unsorted
                    m_OpenList.push_back((*successor));

                    // sort back element into heap
                    push_heap(m_OpenList.begin(), m_OpenList.end(), HeapCompare_f());

                }

                // push n onto Closed, as we have expanded it now

                m_ClosedList.push_back(n);

            } // end else (not goal so expand)
*/
            return m_State; // Succeeded bool is false at this point. 

        }

        private void FreeAllNodes()
        {
            foreach(var n in m_OpenList) 
            {
                FreeNode(n);
            }
            m_OpenList.Clear();
            foreach(var n in m_ClosedList)
            { 
                FreeNode(n); 
            }
            m_ClosedList.Clear();
            FreeNode(m_Goal);
        }

        private void FreeNode(MyOgreLevelNode n)
        {
            n = null;
            m_AllocateNodeCount--;
        }
    }

}