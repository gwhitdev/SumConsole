using System.Collections.Generic;
using System.Collections;
using System;
using System.Linq;

namespace SumConsole
{
    class Sum
    {
        public int X { get; set; } = 0;
        public int Y { get; set; } = 0;
        public List<int> Comp { get; set; } = new List<int>();
        public bool GetPairForSum(List<int> data, int target) // returns True if there is a pair that sums to the target, else returns False
        {
            foreach (var num in data)
            {
                if (Comp.Count > 0 && Comp.Contains(num) && num == Comp[^1])
                {
                    X = Comp[^1];
                    Y = num;
                    Console.WriteLine($"[{8-X},{Y}]");
                    return true;
                }
                Comp.Add((target - num));
            }
            return false;
        }
    }
}
