using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example_6._17._8
{
    class Class1
    {
        private int Temp0;
        private int Temp1;

        public int this[int index]
        {
            get
            {
                return (0 == index) // if index is 0, return Temp0, else return Temp1
                    ? Temp0
                    : Temp1;
            }
            set
            {
                if (0 == index)
                    Temp0 = value;
                else
                    Temp1 = value;

            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Class1 a = new Class1();

            Console.WriteLine("Values -- TO: {0}, T1: {1}", a[0], a[1]); //0, 0

            a[0] = 15;
            a[1] = 20;

            Console.WriteLine("Values -- TO: {0}, T1: {1}", a[0], a[1]); // 15, 20

        }
    }
}
