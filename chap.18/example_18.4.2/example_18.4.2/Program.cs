using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example_18._4._2
{
    class MyClass
    {
        public IEnumerator<string> GetEnumerator()
        {
            return BlackAndWhite(); // return enumerator
        }

        public IEnumerator<string> BlackAndWhite() // create a Iterator, each "yield return" line is a shade item.
        {
            yield return "black"; // yield is the keyword
            yield return "gray";
            yield return "white";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass mc = new MyClass();

            foreach (string shade in mc)
            {
                Console.WriteLine(shade);
            }
        }
    }
}
