using System;
namespace Amazon
{

    public class CourseTaken
    {
        private int[] _result;
        private int resultIndex = 0;
        public int[] FindOrder(int numCourses, int[][] prerequisites)
        {
            _result = new int[numCourses];

            var adjacencyMatrix = new HashSet<int>[numCourses];

            for (int i = 0; i < numCourses; i++)
            {
                adjacencyMatrix[i] = new HashSet<int>();
            }

            foreach (var fromTo in prerequisites)
            {
                var from = fromTo[0];
                var to = fromTo[1];

                adjacencyMatrix[from].Add(to);
            }

            var isVisited = new bool[numCourses];
            var isAdded = new bool[numCourses];

            for (int i = 0; i < numCourses; i++)
            {
                if (isAdded[i]) continue;
                var noCyclic = DFS(i, adjacencyMatrix, isVisited, isAdded);
                if (!noCyclic) return new int[0];
            }

            return _result;
        }

        private bool DFS(int cur, HashSet<int>[] adjacencyMatrix, bool[] isVisited, bool[] isAdded)
        {
            if (isVisited[cur]) return false;

            isVisited[cur] = true;
            var nextCourses = adjacencyMatrix[cur];

            foreach (var next in nextCourses)
            {
                var oneResult = DFS(next, adjacencyMatrix, isVisited, isAdded);
                if (!oneResult) return false;
            }

            if (!isAdded[cur])
            {
                _result[resultIndex] = cur;
                resultIndex++;
                isAdded[cur] = true;
            }

            isVisited[cur] = false;

            return true;
        }
    }
}
