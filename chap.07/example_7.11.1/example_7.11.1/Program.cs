using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example_7._11._1
{
    abstract class AbClass
    {
        public void IdentifyBase()
        {
            Console.WriteLine("I am AbClass");
        }

        abstract public void IdentifyDerived();

    }

    class DerivedClass: AbClass
    {
        override public void IdentifyDerived()
        {
            Console.WriteLine("I am DerivedClass");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // abstract class is can't be re~
            DerivedClass b = new DerivedClass();
            b.IdentifyBase();
            b.IdentifyDerived();
        }
    }
}
