using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example_6._18
{
    class Person
    {
        public string Name { get; private set; }
        //
        public Person(string name)
        {
            Name = name; // set
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("Capt. Ernest Evans");
            Console.WriteLine("Person's name is {0}", p.Name); // get
        }
    }
}
