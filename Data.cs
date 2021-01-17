using System;
using System.Collections.Generic;

namespace SumConsole
{
    class Data
    {
        public static List<int> ListOfData { get; set; }  = new List<int>();
        public static Random Random { get; set; }  = new Random();
        public List<int> MakeData()
        {
            while (ListOfData.Count < 10)
            {
                int randomNumber = Random.Next(1, 10);
                ListOfData.Add(randomNumber);
            };
            return ListOfData;
        }
    }
}
