using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example_12._10._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = {10, 11, 12, 13};

            foreach (int item in arr1)
                Console.WriteLine("Item Value: {0}", item);
        }
    }
}
