using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Advanced
{
    internal class Unit6_isas
    {
        public void Run()
        {
            aaa a = new aaa();
            bbb b = new bbb();
            ccc c = new ccc();
            Operate(c);
        }


        public void Operate(object o)
        {
            // is - return boolean
            bool test = o is aaa; // true
            test = o is bbb; // false
            test = o is ccc; // true
            test = o is object; // true
            test = o is System.IO.FileStream; //false

            if(o is ccc)
            {
                // referance type
                ccc c = o as ccc; // casting
                c = (ccc)o;

                // run metod
                c.Run_ccc();
            }
        }
    }

    class aaa { }
    class bbb { }
    class ccc: aaa
    {
        public void Run_ccc()
        { }
    }
}
