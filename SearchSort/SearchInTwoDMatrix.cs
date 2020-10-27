using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchSort
{
    public class SearchInTwoDMatrix
    {
        public static bool SearchMatrix(int[,] matrix, int target)
        {
            int m = matrix.GetLength(0);
            int n = matrix.GetLength(1);
            int i = 0, j = n - 1;

            while (i < m && j >= 0)
            {
                if (matrix[i, j] == target)
                    return true;
                else if (matrix[i, j] > target)
                    --j;
                else
                    ++i;
            }
            return false;
        }
    }
}
