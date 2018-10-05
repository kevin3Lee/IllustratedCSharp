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
        // define methods
        void PrintLow(int value)
        {
            Console.WriteLine("{0} - Low Value", value);
        }
        void PrintHigh(int value)
        {
            Console.WriteLine("{0} - High Value", value);
        }
        // Main func
        static void Main(string[] args)
        {
            Program program = new Program(); // ?
            MyDel del; //decalre delegate **variable**.
            //
            Random rand = new Random();
            int randomValue = rand.Next(99);
            
            // set a del obj include methods
            del = randomValue < 50 // create a delegate **object**.
                ? new MyDel(program.PrintLow)
                : new MyDel(program.PrintHigh);

            del(randomValue); // execute the delegate object.

        }
    }
}
