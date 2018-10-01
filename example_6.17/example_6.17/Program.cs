using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace example_6._17
{
    class Employee
    {
        public string LastName;
        public string FirstName;
        public string CityOfBirth;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();

            emp1.LastName = "Doe";
            emp1.FirstName = "Jane";
            emp1.CityOfBirth = "Dallas";
            Console.WriteLine("{0}", emp1.LastName);
            Console.WriteLine("{0}", emp1.FirstName);
            Console.WriteLine("{0}",emp1.CityOfBirth);
        }
    }
}
