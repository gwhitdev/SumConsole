using System;

namespace SumConsole
{
    
    class Program
    {
        public static int Target { get; set; } = 8;
        public static Sum Maths { get; set; } = new Sum();
        
        static void Main(string[] args)
        {
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
                Console.WriteLine(Maths.GetPairForSum(data, Target));
                Console.ReadLine();
            }
        }
    }
}
