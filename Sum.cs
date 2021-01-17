using System.Collections.Generic;
using System;

namespace SumConsole
{
    class Sum
    {
        public static int X { get; set; } = 0;
        public static int Y { get; set; } = 0;
        public static List<int> Comp { get; set; } = new List<int>();
        public bool GetPairForSum(List<int> data, int target) // returns True if there is a pair that sums to the target, else returns False
        {
            foreach (var num in data)
            {
                if (Comp.Count > 0 && Comp.Contains(num) && num == Comp[^1])
                {
                    X = Comp[^1];
                    Y = num;
                    Console.WriteLine($"[{target-X},{Y}]");
                    return true;
                }
                Comp.Add((target - num));
            }
            return false;
        }
    }
}
