using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    class longest_consecutive_sequence
    {
        public static int LongestConsecutive(int[] nums)
        {
            HashSet<int> hash = new HashSet<int>(nums);
            int maxLength = 0;

            foreach (var item in hash)
            {

                if (hash.Contains(item - 1)) continue;

                int length = 0;
                while (hash.Contains(length + item)) length++;

                maxLength = Math.Max(length, maxLength);

            }

            return maxLength;
        }


        public static void Run()
        {
            int[] numa = new int[] { 100, 4, 200, 1, 3, 2 ,2,3,3,2,100}; // ans 4
            int[] numb = new int[] { 0, 3, 7, 2, 5, 8, 4, 6, 0, 1 }; // ans 9
            int[] numc = new int[] { 9, 1, 4, 7, 3, -1, 0, 5, 8, -1, 6 }; // ans 7


            Console.WriteLine(LongestConsecutive(numc));

        }
    }
}
