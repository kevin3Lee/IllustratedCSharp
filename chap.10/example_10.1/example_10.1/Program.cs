using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace example_10._1
{
    struct Point
    {
        public int x;
        public int y;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Point first, second, third;

            first.x = 10;
            first.y = 10;
            second.x = 20;
            second.y = 20;
            third.x = first.x + second.x;
            third.y = first.y + second.y;

            Console.WriteLine("first: {0}, {1}", first.x, first.y);
            Console.WriteLine("second: {0}, {1}", second.x, second.y);
            Console.WriteLine("third: {0}, {1}", third.x, third.y);
        }
    }
}
