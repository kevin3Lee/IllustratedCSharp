using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example_15._1
{
    class CA
    {
        public string Name;
        public int Age;
    }

    class CB
    {
        public string First;
        public string Last;
        public double PersonsAge;
    }
    class Program
    {
        static void PrintInfo(CA item)
        {
            Console.WriteLine("Name: {0}, Age: {1}", item.Name, item.Age);
        }
        static void Main(string[] args)
        {
            CA a = new CA() { Name = "John Doe", Age = 35 };
            PrintInfo(a);
        }
    }
}
