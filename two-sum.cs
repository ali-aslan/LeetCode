using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class two_sum
    {

        public static int[] TwoSum(int[] nums, int target)
        {

            //Aproach 0ne brutual force 
            //for (int i = 0; i < nums.Length; i++)
            //{
               
            //    for (int k = i+1; k < nums.Length; k++)
            //    {
            //            if (nums[i] + nums[k] == target)
            //            {

            //            return new int[] { i, k };

            //        }
            //            else
            //            {
            //                continue;
            //            }
            //    }
            //}
            //return new int[] { };


            //Aproach Two hashmap
            Dictionary<int,int> pairs = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
                if (pairs.ContainsKey(target - nums[i]))
                    return new int[] { pairs[target - nums[i]], i };
                else
                    pairs.TryAdd(nums[i], i);

            return default;


        }

        public static void Run()
        {

            int[] arr = { 21, 17, 3, 7 };

            int target = 10;

            //int[] arr = { 0, 4, 3, 0 };

            //int target = 0;

            int[] ans = TwoSum(arr, target);

            Console.Write(ans[0]+" "+ ans[1]);
        }
    }
}
