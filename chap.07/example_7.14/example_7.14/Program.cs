using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example_7._14
{   // extended method
    class MyData
    {
        private double D1; // field
        private double D2;
        private double D3;

        public MyData(double d1, double d2, double d3) // () => parameters
        {
            D1 = d1; // Field = Parameters
            D2 = d2;
            D3 = d3;
        }

        public double Sum()
        {
            return D1 + D2 + D3;
        }
    }
    //
    static class ExtendMyData
    {
        public static double Average(this MyData md)
        {
            return md.Sum() / 3;
        }
    }
    //
    class Program
    {
        static void Main(string[] args)
        {
            MyData md = new MyData(3, 4, 5); // constrction function
            Console.WriteLine("Average: {0}", ExtendMyData.Average(md));
        }
    }
}
