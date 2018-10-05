using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example_13._1
{
    delegate void MyDel(int value); // declare delegate TYPE, like 'int xxx'

    class Program
    {
        //
        class MyClass
        {
            //
            // define methods
            public void PrintLow(int value)
            {
                Console.WriteLine("{0} - Low Value", value);
            }
            public void PrintHigh(int value)
            {
                Console.WriteLine("{0} - High Value", value);
            }
        }
        
        // Main func
        static void Main(string[] args)
        {
            MyClass mc = new MyClass(); // ?
            MyDel del_obj; //decalre delegate **variable**.
            //
            Random rand = new Random();
            int randomValue = rand.Next(99);
            
            // set a del obj include methods
            del_obj = randomValue < 50 // create a delegate **object**.
                ? new MyDel(mc.PrintLow) // Create delegate and save ref. Instance method.
                : new MyDel(mc.PrintHigh); // Create delegate and save ref. Instance method.

            del_obj(randomValue); // execute the delegate object.

        }
    }
}
