using org.ogre;

namespace MyOgreProgram.Classes
{
    public class PathFinder
    {
        bool mFoundSolution;        // have we found a path
        MyOgreLevel mMap;             // world map
        AStarSearch mAStarSearch;        // the A* search object
        uint mSearchCount;      // Number of searches
        MyLevelSearchNode mStartNode;           // Starting node
        MyLevelSearchNode mEndNode;         // End node
        static uint NUM_SEARCHES = 1; // How many searches can we take
        Random random;


        public PathFinder(MyOgreLevel map)
        {
            mMap = map;
            // seed random number gen
            //srand(time(0));
            random = new Random(DateTime.Now.Millisecond);

            mStartNode = new MyLevelSearchNode(mMap);
            mEndNode = new MyLevelSearchNode(mMap);
            mSearchCount = 0;

            // set start and end nodes
            SetStartEndNodes();

        }

        public PathFinder(MyOgreLevel map, Vector3 startingPoint)
        {
            mMap = map;
            // seed random number gen
            random = new Random(DateTime.Now.Millisecond);

            mStartNode = new MyLevelSearchNode(mMap);
            mEndNode = new MyLevelSearchNode(mMap);
            mSearchCount = 0;

            SetStartEndNodes(startingPoint);
        }

        // Run the path finder
        public void Run()
        {
            // set flag
            mFoundSolution = false;

            // try new paths until we have a solution
            do
            {
                // try and find a path
                FindPath();

                // if we haven't found a solution, we will reset everything 
                // before the loop tries again
                if (!mFoundSolution)
                {
                    // create a new end point and reset
                    GetNewEndNode();
                    ResetSearch();
                }
            } while (!mFoundSolution);
        }

        // Convert nodes into Ogre::Vector3 objects and fill
        // the deque passed to this function with those Vectors
        public void GetResults(out Queue<Vector3> waypoints)
        {
            waypoints = new Queue<Vector3>();

            MyLevelSearchNode? node = mAStarSearch.GetSolutionStart();

            Vector3 waypointStart = new Vector3((float)(node.x * 64.0f), 0.0f, (float)(node.y * 64.0f));
            waypoints.Enqueue(waypointStart);

            int steps = 0;
            node = mAStarSearch.GetSolutionNext();
            while (node != null)
            {
                Vector3 waypoint = new Vector3((float)(node.x * 64.0f), 0.0f, (float)(node.y * 64.0f));
                waypoints.Enqueue(waypoint);
                steps++;
                node = mAStarSearch.GetSolutionNext();
            }
        }

        // Find the shortest path between start and end nodes
       public void FindPath()
        {
            while (mSearchCount < NUM_SEARCHES)
            {
                // Set Start and goal states
                mAStarSearch.SetStartAndGoalStates(mStartNode, mEndNode);

                uint SearchState;
                uint SearchSteps = 0;

                // step through our path and find a solution
                do
                {
                    SearchState = mAStarSearch.SearchStep();
                    SearchSteps++;
                }
                while (SearchState == mAStarSearch.SEARCH_STATE_SEARCHING);


                if (SearchState == mAStarSearch.SEARCH_STATE_SUCCEEDED)
                {
                    // search succeeded
                    mFoundSolution = true;

                }
                else if (SearchState == mAStarSearch.SEARCH_STATE_FAILED)
                {
                    // search failed
                    mFoundSolution = false;
                }
                mSearchCount++;
            }
        }

        // Generate random start and end nodes
        void SetStartEndNodes()
        {

        }

        // Generate a random end node, using a known vector as a starting location
        void SetStartEndNodes(Vector3 startingPoint)
        {

        }

        // Generate a new random end node
        void GetNewEndNode()
        {

        }

        // Reset the search 
        void ResetSearch()
        {

        }
    }

}