using System;
using System.Collections.Generic;
/*
There are a total of n courses you have to take labelled from 0 to n - 1.
Some courses may have prerequisites, for example, if prerequisites[i] = [ai, bi] this means you must take the course bi before the course ai.
Given the total number of courses numCourses and a list of the prerequisite pairs, return the ordering of courses you should take to finish all courses.
If there are many valid answers, return any of them. If it is impossible to finish all courses, return an empty array.
 */
namespace TreeGraph
{
    public class CourseTaken
    {
        private static int[] _result;
        private static int resultIndex = 0;
        public static int[] FindOrder(int numCourses, int[][] prerequisites)
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
                
                if (isAdded[i]) 
                    continue;
                var noCyclic = DFS(i, adjacencyMatrix, isVisited, isAdded);
                if (!noCyclic) 
                    return new int[0];
            }

            return _result;
        }

        private static bool DFS(int cur, HashSet<int>[] adjacencyMatrix, bool[] isVisited, bool[] isAdded)
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
