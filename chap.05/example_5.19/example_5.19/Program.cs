using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example_5._19
{
    class Program
    {
        static void MethodA(int par1, int par2)
        {
            Console.WriteLine("Enter MethodA: {0},{1}", par1, par2);
            MethodB(11, 18);
            Console.WriteLine("Exit MethodA");
        }

        static void MethodB(int par1, int par2)
        {
            Console.WriteLine("Enter MethodB: {0},{1}", par1, par2);
            Console.WriteLine("Exit MethodB");
        }
        //
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Main");
            MethodA(15, 30);
            Console.WriteLine("Exit Main");
        }
    }
}
