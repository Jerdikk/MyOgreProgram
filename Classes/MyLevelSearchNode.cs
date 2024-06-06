using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOgreProgram.Classes
{
    public class MyLevelSearchNode
    {
        public int x;
        public int y;

        public MyOgreLevel ogreLevel;

        public MyLevelSearchNode()
        {
            x = 0;
            y = 0;
        }

        public MyLevelSearchNode(MyOgreLevel ogreLevel)
        {
            this.ogreLevel = ogreLevel;
            x = 0;
            y = 0;
        }

        public MyLevelSearchNode(MyOgreLevel ogreLevel, int x, int y)
        {
            this.x = x;
            this.y = y;
            this.ogreLevel = ogreLevel;
        }

        public static bool operator ==(MyLevelSearchNode a, MyLevelSearchNode b)
        {
            return (a.x == b.x) && (a.y == b.y);
        }
        public static bool operator !=(MyLevelSearchNode a, MyLevelSearchNode b)
        {
            return !(a == b);
        }

        // Compare this node against another node
        public bool IsSameState(MyLevelSearchNode rhs)
        {
            // same state in a maze search is simply when (x,y) are the same
            if ((x == rhs.x) &&
                (y == rhs.y))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Here's the heuristic function that estimates the distance from a Node
        // to the Goal. 
        public float GoalDistanceEstimate(MyLevelSearchNode nodeGoal)
        {
            float xd = Math.Abs((((float)x - (float)nodeGoal.x)));
            float yd = Math.Abs((((float)y - (float)nodeGoal.y)));

            return xd + yd;
        }

        // Test this node to see if it is the goal in our search
        public bool IsGoal(MyLevelSearchNode nodeGoal)
        {
            if ((x == nodeGoal.x) &&
                    (y == nodeGoal.y))
            {
                return true;
            }

            return false;
        }

        // This generates the successors to the given Node. It uses a helper function called
        // AddSuccessor to give the successors to the AStar class. The A* specific initialisation
        // is done for each node internally, so here you just set the state information that
        // is specific to the application
        public bool GetSuccessors(AStarSearch astarsearch, MyLevelSearchNode parent_node)
        {
            int parent_x = -1;
            int parent_y = -1;

            if (parent_node != null)
            {
                parent_x = (int)parent_node.x;
                parent_y = (int)parent_node.y;
            }

            MyLevelSearchNode NewNode;

            // push each possible move except allowing the search to go backwards

            if ((ogreLevel.GetTile(x - 1, y) < 9)
                && !((parent_x == x - 1) && (parent_y == y))
                )
            {
                NewNode = new MyLevelSearchNode(ogreLevel, x - 1, y);
                astarsearch.AddSuccessor(NewNode);
            }

            if ((ogreLevel.GetTile(x, y - 1) < 9)
                && !((parent_x == x) && (parent_y == y - 1))
                )
            {
                NewNode = new MyLevelSearchNode(ogreLevel, x, y - 1);
                astarsearch.AddSuccessor(NewNode);
            }

            if ((ogreLevel.GetTile(x + 1, y) < 9)
                && !((parent_x == x + 1) && (parent_y == y))
                )
            {
                NewNode = new MyLevelSearchNode(ogreLevel, x + 1, y);
                astarsearch.AddSuccessor(NewNode);
            }


            if ((ogreLevel.GetTile(x, y + 1) < 9)
                && !((parent_x == x) && (parent_y == y + 1))
                )
            {
                NewNode = new MyLevelSearchNode(ogreLevel, x, y + 1);
                astarsearch.AddSuccessor(NewNode);
            }

            return true;
        }


        // Given this node, what does it cost to move to successor. In the case
        // of our map the answer is the map terrain value at this node since that is 
        // conceptually where we're moving
        public float GetCost(MyLevelSearchNode successor)
        {
            return (float)ogreLevel.GetTile((int)x, (int)y);
        }

    }
}
