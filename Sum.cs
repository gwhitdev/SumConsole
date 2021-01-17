using System.Collections.Generic;
using System.Collections;
using System;
using System.Linq;

namespace SumConsole
{
    class Sum
    {
        public bool GetPairForSum(List<int> data, int target) // returns True if there is a pair that sums to the target, else returns False
        {
            List<int> comp = new List<int>();
            int x = 0;
            int y = 0;
            foreach (var num in data)
            {
                if (comp.Count > 0 && comp.Contains(num) && num == comp[^1])
                {
                    x = comp[^1];
                    y = num;
                    Console.WriteLine($"[{8-x},{y}]");
                    return true;
                }
                comp.Add((target - num));
            }
            return false;
        }
    }
}
