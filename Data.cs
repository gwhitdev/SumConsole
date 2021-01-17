using System;
using System.Collections.Generic;

namespace SumConsole
{
    class Data
    {
        public List<int> MakeData()
        {
            List<int> data = new List<int>();
            Random random = new Random();
            while (data.Count < 5)
            {
                int randomNumber = random.Next(1, 10);
                data.Add(randomNumber);
            };
            return data;
        }
    }
}
