using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example_7._1
{
    class BaseClass
    {
        public string FieldOfBase = "base class field";

        public void MethodOfBase(string value)
        {
            Console.WriteLine("Base class -- Method_Base: {0}", value);
        }
    }

    class ChildClass : BaseClass //derived class
    {
        public string FieldOfChild = "derived class field";

        public void MethodOfChild(string value)
        {
            Console.WriteLine("Derived class -- Method_Child: {0}", value);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ChildClass dc = new ChildClass(); //derived class obj

            dc.MethodOfBase(dc.FieldOfBase);
            dc.MethodOfBase(dc.FieldOfChild);
            dc.MethodOfChild(dc.FieldOfBase);
            dc.MethodOfChild(dc.FieldOfChild);
        }
    }
}
