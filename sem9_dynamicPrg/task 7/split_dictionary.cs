using System;
using System.Collections.Generic;
using System.Linq;

namespace sem9_dynamicPrg.task_7
{
    public class split_dictionary
    {
        public static bool solve(string T, List<string> Dict)
        {
            int i = 0;
            if (Dict.Count == 0)
                return false;
            string[] str = T.Split(Dict[i]);
            str = str.Where(c => c != "").ToArray();

            string newT = String.Concat(str);
            Dict.Remove(Dict[i]);
            bool res = solve(newT, Dict);

            if (res)
                return true;
            return str.Length == 0;

        }
    }
}