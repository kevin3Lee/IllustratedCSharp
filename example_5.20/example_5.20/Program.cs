using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example_5._20
{
    class Program
    {
        public void Count(int inVal)
        {
            if (inVal == 0)
                return;
            Count(inVal - 1);
            Console.WriteLine("{0}", inVal);
        }

        static void Main(string[] args)
        {
            Program pr = new Program();
            pr.Count(3);
        }
    }
}
