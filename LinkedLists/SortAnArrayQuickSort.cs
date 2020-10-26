using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    public class SortAnArrayQuickSort
    {
        public static void QuickSort(int[] nums, int low, int high)
        {
            if (low < high)
            {
                int pivot = Findpivot(nums, low, high);

                Findpivot(nums, low, pivot - 1);
                Findpivot(nums, pivot + 1, high);
            }
        }

        private static int Findpivot(int[] nums, int low, int high)
        {


            int i = low;
            int pivot = nums[high];

            for (int j = low; j < high; j++)
            {
                if (nums[j] < pivot)
                {
                    int temp = nums[i];
                    nums[i] = nums[j];
                    nums[j] = temp;
                    i++;
                }

            }


            int temp1 = nums[high];
            nums[high] = nums[i];
            nums[i] = temp1;

            return i;
        }
    }
}
