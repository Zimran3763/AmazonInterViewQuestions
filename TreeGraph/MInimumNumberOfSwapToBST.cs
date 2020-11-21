using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeGraph
{
    public class MInimumNumberOfSwapToBST
    {
        public static void InOrder(int[] a, int[] v,int n, int index)
        {
            if(index >= n)
            {
                return;
            }
            InOrder(a, v, n, 2 * index + 1);
          
            // push elements in vector 
            v[index] = a[index];
            InOrder(a, v, n, 2 * index + 2);

        }
        public static int MinSwap(int[] source)
        {
            int minSwap = 0;
            int n = source.Length;
            int[] target = new int[source.Length];
            Array.Copy(source, target,n );
            Array.Sort(target);
            Dictionary<int, int> hashTable = new Dictionary<int, int>();
            //add value from array as key and i as value in dictionary
            for(int i=0; i<n;i++)
            {
                hashTable.Add(source[i],i);
            }
            for (int i = 0; i < n; i++)
            {
                if (source[i] != target[i])
                {
                    minSwap++;
                    int IndexValue = source[i];
                    Swap(source, i, hashTable[target[i]]);
                    //update hashtable key value to target key value index
                    hashTable[IndexValue] = hashTable[target[i]];
                    //
                    hashTable[target[i]] = i;
                }
            }
            return minSwap;
        }
        private static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}
