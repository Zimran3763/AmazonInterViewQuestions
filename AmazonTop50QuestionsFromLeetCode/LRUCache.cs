using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Design a data structure that follows the constraints of a Least Recently Used (LRU) cache.

Implement the LRUCache class:

LRUCache(int capacity) Initialize the LRU cache with positive size capacity.
int get(int key) Return the value of the key if the key exists, otherwise return -1.
void put(int key, int value) Update the value of the key if the key exists. Otherwise, add the key-value pair to the cache. If the number of keys exceeds the capacity from this operation, evict the least recently used key.
Follow up:
Could you do get and put in O(1) time complexity?

 

Example 1:

Input
["LRUCache", "put", "put", "get", "put", "get", "put", "get", "get", "get"]
[[2], [1, 1], [2, 2], [1], [3, 3], [2], [4, 4], [1], [3], [4]]
Output
[null, null, null, 1, null, -1, null, -1, 3, 4]

Explanation
LRUCache lRUCache = new LRUCache(2);
lRUCache.put(1, 1); // cache is {1=1}
lRUCache.put(2, 2); // cache is {1=1, 2=2}
lRUCache.get(1);    // return 1
lRUCache.put(3, 3); // LRU key was 2, evicts key 2, cache is {1=1, 3=3}
lRUCache.get(2);    // returns -1 (not found)
lRUCache.put(4, 4); // LRU key was 1, evicts key 1, cache is {4=4, 3=3}
lRUCache.get(1);    // return -1 (not found)
lRUCache.get(3);    // return 3
lRUCache.get(4);    // return 4
*/
namespace AmazonTop50QuestionsFromLeetCode
{
    public class LRUCache
    {
        public LinkedList<CacheItems> item;
        public Dictionary<int, LinkedListNode<CacheItems>> keys;
        public int count;
        public int _capacity;
        public LRUCache(int capacity)
        {
            //intialize 
            item = new LinkedList<CacheItems>();
            keys = new Dictionary<int, LinkedListNode<CacheItems>>(capacity);
            count = 0;
            _capacity = capacity;
        }

        public int Get(int key)
        {
            //return -1 if key not exist
            if (!keys.ContainsKey(key))
            {
                return -1;
            }
            //get the value of key from Dictionary 
            var v = keys[key];

            //check if this is first in linkedList
            //if not then remove it and at it so we would be sure that this last used
            if (v != item.First)
            {
                item.Remove(v);
                item.AddFirst(v);
            }

            return v.Value.value;
        }

        public void Put(int key, int value)
        {
            //put key value if key not exist
            if (!keys.ContainsKey(key))
            {
                //in front so we would know that this is last used
                keys[key] = item.AddFirst(new CacheItems(key, value));

                //if dictionary is full then remove least used key
                if (count == _capacity)
                {
                    //take out least used which is last in the list
                    //we need key first to remove it from dictionary
                    // so put it in the varible and then get key and remove it from                   //dictionary then remove also from list
                    var last = item.Last;
                    keys.Remove(last.Value.key);
                    item.RemoveLast();
                }
                else
                    //if count is not equal to capacity then increase 1 
                    count++;
            }
            //else update
            else
            {
                //get the value of the key
                var cache = keys[key];
                //update the value of key
                cache.Value.value = value;
                //we used this key so it needs to be first in the list
                //if value of key is not first in the list
                //then remove it from list and add it in the front
                if (cache != item.First)
                {
                    item.Remove(cache);
                    item.AddFirst(cache);
                }
            }
        }
        public class CacheItems
        {
            public int key;
            public int value;
            public CacheItems(int k, int v)
            {
                key = k;
                value = v;
            }
        }
    }
}
