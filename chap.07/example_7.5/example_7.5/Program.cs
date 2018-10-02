using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example_7._5
{
    class SomeClass
    {
        public string Field1 = "Field1 -- In the base class";

    }
    //
    class OtherClass : SomeClass
    {
        new public string Field1 = "Field1 -- In the derived class";

        public void PrintField()
        {
            Console.WriteLine(Field1); // derived class
            Console.WriteLine(base.Field1); // base class
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            OtherClass oc = new OtherClass();
            oc.PrintField();
        }
    }
}
