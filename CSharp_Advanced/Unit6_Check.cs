using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Advanced
{

    public class Unit6_Check
    {
        public void Run()
        {
            byte a = byte.MaxValue - 2;
            try
            {
                checked
                {
                    a++;
                    a++;
                    unchecked
                    {
                        a++;
                    }
                    a = byte.MaxValue;
                    a++;
                }
            }
            catch (OverflowException ex)
            {

            }

            // byte a = 1;
            int b = 2;
            for (long i = 0; i < long.MaxValue; i++)
            {
                // a++;
                b++;
            }


        }
    }
}
