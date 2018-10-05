using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example_12._10._1
{
    class MyClass
    {
        public int MyField = 0;
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass[] mcArray = new MyClass[4];

            for (int i = 0; i < 4; i++)
            {
                mcArray[i] = new MyClass();
                mcArray[i].MyField = i;
            }

            foreach (MyClass item in mcArray)
            {
                item.MyField += 10;
            }

            foreach (MyClass item in mcArray)
            {
                Console.WriteLine("{0}",item.MyField);
            }
        }
    }
}
