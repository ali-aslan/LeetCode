using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    class valid_anagram
    {

        public static bool IsAnagram(string s, string t)
        {
            // approach one 
            //foreach (char item in s)
            //{
            //    int index=t.IndexOf(item);
            //    if (index == -1)
            //        return false;

            //    t=t.Remove(index,1);

            //}

            //if(t.Length>0)
            //return false;
            //else
            //return true;

            ///approach two

            //s = String.Concat(s.OrderBy(c => c));
            //t = String.Concat(t.OrderBy(c => c));
            //return s == t ? true : false;

            ///approach three

            if (s.Length != t.Length)
            {
                return false;
            }

            Dictionary<char, int> symbolFrequency = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                symbolFrequency.TryAdd(s[i], 0);
                symbolFrequency.TryAdd(t[i], 0);

                symbolFrequency[s[i]]++;
                symbolFrequency[t[i]]--;
            }

            return symbolFrequency.Values.All(frequence => frequence == 0);


        }

        public static void Run()
        {
            string s = "nagaram";
            string t = "anagram";

            Console.WriteLine(IsAnagram(s,t));
        }



    }
}
