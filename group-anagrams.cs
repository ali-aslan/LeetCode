using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    class group_anagrams
    {
 

        public static IList<IList<string>> GroupAnagramsB(string[] strs)
        {
            return strs
                .GroupBy(s => new string(s.OrderBy(c => c).ToArray()))
                .Select(g => g.ToList() as IList<string>)
                .ToList();
        }


        public static IList<IList<string>> GroupAnagramsA(string[] strs)
        {
            Dictionary<string, IList<string>> dicti = new Dictionary<string, IList<string>>();

            for (int i = 0; i < strs.Length; i++)
            {
                char[] sort = strs[i].ToCharArray();
                Array.Sort(sort);
                string sorted = new string(sort);

                if(!dicti.ContainsKey(sorted))
                {
                    dicti.Add(sorted, new List<string>() { strs[i] });

                }
                else
                {
                    dicti[sorted].Add(strs[i]);

                }

               

            }
            return dicti.Values.ToList();

        }




        public static void Run()
        {
            string[] s = { "eat", "tea", "tan", "ate", "nat", "bat" };

            GroupAnagramsA(s);
            GroupAnagramsB(s);

        }
    }
}
