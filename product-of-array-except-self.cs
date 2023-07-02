using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class product_of_array_except_self
    {
        public static int[] ProductExceptSelfA(int[] nums)
        {
            int[] ans = new int[nums.Length];
            int num = 1, i;

            for (i = 0; i < nums.Length; i++)
            {
                ans[i] = num;
                num *= nums[i];
            }
            num = 1;

            for (i = nums.Length - 1; i >= 0; i--)
            {
                ans[i] *= num;
                num *= nums[i];
            }
            return ans;

        }

        public static void Run()
        {
           int[] nums = { 1,2,3,4 };
            //int[] nums = { 0,0 };

            foreach (var item in ProductExceptSelfA(nums))
            {
                Console.WriteLine(item);
            }
          

        }
    }
}
