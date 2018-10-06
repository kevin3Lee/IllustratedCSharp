
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example_19._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {2, 12, 5, 15};

            IEnumerable<int> lowNums = // define a enumrator to store the query
                from n in numbers
                where n < 10
                select n;

            foreach (var x in lowNums)
            {
                Console.Write("{0}, ",x);
            }
        }
    }
}
