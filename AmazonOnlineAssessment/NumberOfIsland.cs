using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 200. Number of Islands
Medium

7030

224

Add to List

Share
Given an m x n 2d grid map of '1's (land) and '0's (water), return the number of islands.

An island is surrounded by water and is formed by connecting adjacent lands horizontally or vertically. You may assume all four edges of the grid are all surrounded by water.
 */
namespace AmazonOnlineAssessment
{
    public class NumberOfIsland
    {
        public int NumIslands(char[][] grid)
        {
            // 1 means it's not visited
            // 2 means it's visited
            int rows = grid.Length;
            if (rows == 0) return 0;
            int col = grid[0].Length;
            int numberOfIsland = 0;
            //check if cell is marked 1 means not visited
            //call Dfs funstion to mark it 2 as visited and 
            //as well as mark all the cells top bottom left right as 2(visited)
            //and increment numberOfIsland by 1
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (grid[i][j] == '1')
                    {
                        Dfs(grid, i, j, rows, col);
                        numberOfIsland++;
                    }
                }
            }
            return numberOfIsland;
        }

        private void Dfs(char[][] grid, int x, int y, int rows, int col)
        {
            //don't process if it's not land(!=1), and rows and columns coordinate are greater than               //Rows & Cols
            if (x < 0 || y < 0 || x >= rows || y >= col || grid[x][y] != '1')
                return;

            //Mark as visited
            grid[x][y] = '2';
            Dfs(grid, x - 1, y, rows, col);//top cell
            Dfs(grid, x + 1, y, rows, col);//botom cell
            Dfs(grid, x, y + 1, rows, col);//right cell
            Dfs(grid, x, y - 1, rows, col);//left cell


        }

    }
}
