using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example_12._6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myIntArray;
            myIntArray = new int[4]; // a new array with 4 ints

            for (int i=0; i < 4; i++)
                myIntArray[i] = i * 10;

            for(int i=0; i < 4; i++)
                Console.WriteLine("Value of element {0} = {1}", i, myIntArray[i]);
        }
    }
}
