using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example_13._11
{
    delegate int MyDel(); // declare delegate with return value

    class MyClass
    {
        private int IntValue = 5;

        public int Add2()
        {
            IntValue += 2;
            return IntValue;
        }

        public int Add3()
        {
            IntValue += 3;
            return IntValue;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass mc = new MyClass();
            MyDel md = mc.Add2; // 5+2=7
            md += mc.Add3; // 7+3=10
            md += mc.Add2; // 10+2=12, as the last return value
            
            Console.WriteLine("Value{0}", md()); // INVOKE THE DELEGATE AND USE THE RETURN VALUE.
        }
    }
}
