using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example_11._1
{
    enum TrafficLight
    {
        Green,
        Yellow,
        Red
    }
    class Program
    {
        static void Main(string[] args)
        {
            TrafficLight t1 = TrafficLight.Red;
            TrafficLight t2 = TrafficLight.Green;
            TrafficLight t3 = t2;

            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
        }
    }
}
