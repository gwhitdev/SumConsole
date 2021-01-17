using System;

namespace SumConsole
{
    
    class Program
    {
        static void Main(string[] args)
        {
            int target = 8;
            Sum maths = new Sum();
            var myData = new[]
            {
                new Data().MakeData(),
                new Data().MakeData(),
                new Data().MakeData(),
            };
            foreach(var data in myData)
            {
                Console.Write("[");
                foreach(var num in data)
                {
                    Console.Write($"{num}, ");
                }
                Console.Write("]");
                Console.WriteLine(maths.GetPairForSum(data, target));
                Console.ReadLine();
            }
        }
    }
}
