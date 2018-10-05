using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example_14._5
{
    delegate void Handler();
    //
    //
    class P_Incrementer
    {
        public event Handler P_evt_CountedADozen; // decalre the event.

        public void P_m_DoCount()
        {
            for (int i = 1; i < 100; i++)
            {
                if (i % 12 == 0 && P_evt_CountedADozen != null) // make sure there are methods to execute.
                {
                    P_evt_CountedADozen(); // RAISE A EVENT every 12 counts.
                }
            }
        }
    }
    //
    //
    class S_Dozens
    {
        public int S_DozensCount { get; private set; } // define S_DozensCount as a int counter.

        public S_Dozens(P_Incrementer p_incrementer) // construct function and define a instance method
        {
            S_DozensCount = 0; // define and init

            // RECEIVE the EVENT : P_evt_CountedADozen and revoke the counter!
            p_incrementer.P_evt_CountedADozen += S_IncrementDozensCount; 
        }

        void S_IncrementDozensCount()
        {
            S_DozensCount++; // int counter
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            P_Incrementer incrementer = new P_Incrementer();
            S_Dozens s_dozensCount = new S_Dozens(incrementer);

            incrementer.P_m_DoCount();
            Console.WriteLine("Number of dozens  = {0}", s_dozensCount.S_DozensCount);
        }
    }
}
