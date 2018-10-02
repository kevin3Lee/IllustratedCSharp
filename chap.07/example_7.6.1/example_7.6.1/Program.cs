using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example_7._6._1
{
    class MyBaseClass
    {
        virtual public void Print()
        {
            Console.WriteLine("This if the base class");
        }
    }

    class MyDerivedClass : MyBaseClass
    {
        override public void Print()
        {
            Console.WriteLine("This is the derived class");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyDerivedClass derived = new MyDerivedClass();
            MyBaseClass mybc = new MyBaseClass();
            MyBaseClass mybc2 = (MyBaseClass) derived;

            derived.Print();
            mybc.Print();
            mybc2.Print();
        }
    }
}
