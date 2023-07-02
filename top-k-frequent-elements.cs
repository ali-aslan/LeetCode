using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    class top_k_frequent_elements
    {

        public static int[] TopKFrequentA(int[] nums, int k) //Dictionary
        {
            Dictionary<int, int> dicti = new Dictionary<int, int>();
            int[] ans = new int[k];

            for (int i = 0; i < nums.Length; i++)
            {
                if (!dicti.ContainsKey(nums[i]))
                {
                    dicti.Add(nums[i], 1);

                }
                else
                {
                    dicti[nums[i]]++;
                }

            }
  
            var result = new List<int>();
            foreach (var d in dicti.OrderByDescending(d => d.Value))
            {
                if (result.Count < k)
                {
                    result.Add(d.Key);
                    continue;
                }
                break;
            }
            return result.ToArray();
        }

        public static int[] TopKFrequentB(int[] nums, int k)  //Linkq
        {
            return nums.GroupBy(num => num) .OrderByDescending(num => num.Count()) .Take(k) .Select(c => c.Key) .ToArray();
        }

        public static void Run()
        {


            int[] nums = { 0, 0, 1, 1, 1, 2, 2, 3 };

            int k = 2;

            int[] ans = TopKFrequentA(nums, k);


            foreach (int item in ans)
            {
                Console.Write(item + " ");
            }






        }
    }
}
