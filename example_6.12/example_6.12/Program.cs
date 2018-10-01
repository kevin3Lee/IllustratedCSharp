using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example_6._12
{
    class RandomNumberClass
    {
        private static Random RandomKey;

        static RandomNumberClass()
        {
            RandomKey = new Random(); 
        }

        public int GetRandomNumber()
        {
            return RandomKey.Next();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            RandomNumberClass a = new RandomNumberClass();
            RandomNumberClass b = new RandomNumberClass();

            Console.WriteLine("Next Random #: {0}", a.GetRandomNumber());
            Console.WriteLine("Next Random #: {0}", b.GetRandomNumber());
        }
    }
}
