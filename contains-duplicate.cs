using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    class contains_duplicate
    {
        public static bool ContainsDuplicate(int[] nums)
        {

            int[] a = nums.Distinct().ToArray();
            if (a.Length == nums.Length)
                return false;
            else
                return true;

        }


        public static void Run()
        {
            int[] arr = { 1, 2, 3, 1};

            Console.WriteLine(ContainsDuplicate(arr));
        }
    }
}
