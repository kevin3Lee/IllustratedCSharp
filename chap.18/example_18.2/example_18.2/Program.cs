using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example_18._2
{
    class Program
    {
        static void Main(string[] args) // does manually foreach statement with a enumerator
        {
            int[] MyArray = {10, 11, 12, 13};

            IEnumerator ie = MyArray.GetEnumerator(); // the key method: GetEnumerator()

            while (ie.MoveNext())
            {
                int i = (int) ie.Current;
                Console.WriteLine("{0}",i);
            }
        }
    }
}
