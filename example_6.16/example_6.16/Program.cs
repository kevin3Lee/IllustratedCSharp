using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example_6._16
{
    class MyClass
    {
        private int Var1 = 10; //field

        public int ReturnMaxSum(int Var1) //parameter
        {
            return Var1 > this.Var1
                ? Var1 //parameter
                : this.Var1; //field
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass mc = new MyClass();

            Console.WriteLine("Max: {0}", mc.ReturnMaxSum(30)); //30
            Console.WriteLine("Max: {0}", mc.ReturnMaxSum(5)); //10
        }
    }
}
