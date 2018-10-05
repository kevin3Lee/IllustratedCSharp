using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example_15._1
{
    interface IInfo // declare the INTERFACE.
    {
        string GetName();
        string GetAge();
    }

    class CA : IInfo
    {
        public string Name;
        public int Age;
        
        // 2 methods in Class CA.
        public string GetName()
        {
            return Name;
        }

        public string GetAge()
        {
            return Age.ToString();
        }
    }

    class CB : IInfo
    {
        public string First;
        public string Last;
        public double PersonsAge;
        
        // 2 methods in Class CB.
        public string GetName()
        {
            return First + " " + Last;
        }

        public string GetAge()
        {
            return PersonsAge.ToString();
        }
    }
    class Program
    {
        static void PrintInfo(IInfo item) //pass objs as references to the INTERFACE.
        {
            Console.WriteLine("Name: {0}, Age: {1}", item.GetName(), item.GetAge());
        }
        static void Main(string[] args)
        {
            CA a = new CA() { Name = "John Doe", Age = 35 };
            CB b = new CB(){First = "Jane", Last = "Doe", PersonsAge = 33};
            PrintInfo(a);
            PrintInfo(b);
        }
    }
}
