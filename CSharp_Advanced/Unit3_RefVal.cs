using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Advanced
{
    internal class Unit3_RefVal
    {
        public void Run()
        {
            Label l = new Label(); 
            l.Text = "456";
            ChangeLabel(l); // by referance

            int a = 10;
            Change(a); // by value

            int b = 10;
            ChangeByRef(ref b); // by referance

            int c;
            ChangeByRefOut(ref a, out c);
        }


        public int ChangeLabel(Label l)
        {
            string s;
            // located on Heap
            s = "12132456465465432546464165dfdkjvlkcjbvxf";


            l.Text = "123";
            return 10;
        }
        public int Change(int a)
        {
            a++;
            return a * a;
        }
        public int ChangeByRef(ref int a)
        {
            a++;
            return a * a;
        }
        public void ChangeByRefOut(ref int a, out int b)
        {
            a++;
            b = a * a;
        }
    }
}
