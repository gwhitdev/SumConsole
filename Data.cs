using System;
using System.Collections.Generic;

namespace SumConsole
{
    class Data
    {
        public List<int> ListOfData { get; set; }  = new List<int>();
        public Random random { get; set; }  = new Random();
        public List<int> MakeData()
        {
            while (ListOfData.Count < 5)
            {
                int randomNumber = random.Next(1, 10);
                ListOfData.Add(randomNumber);
            };
            return ListOfData;
        }
    }
}
