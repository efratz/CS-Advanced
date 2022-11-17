using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Advanced
{
    internal class Unit8_Generics
    {
        public void Run()
        {
            List<string> list = new List<string>();
            list.Add("6555");

            List<int> list2 = new List<int>();
            list2.Add(1);
            Point point = new Point(100,100);
            string s = func<Point, string>(point, "This is my point");



            MyStruct myStruct;
            myStruct.a = 1;
            Point p2 = new Point(100,100);
            p2.Y = 12;

            // public class Sample<T> where T : unmanaged
            // Sample<int> sample = new Sample<int>();

            // public class Sample<T> where T : a
            // Sample<b> sample = new Sample<b>();

            // public class Sample<T, Z> where T : IEnumerable<Z>
            // Sample<List<int>, int> sample = new Sample<List<int>, int>();

            //public class Sample<T> where T : a, new() - public ctor
            b sampleB = b.Create();
            Sample<a> sample = new Sample<a>();


            //Sample<PrintManager> sample = new Sample<PrintManager>();

            // Sample<MyStruct> sample = new Sample<MyStruct>();
            // sample.SetItem(new Point(100,100));
        }


        // managed && unmanaged - struct, primitive types
        public class Sample<T> where T : a, new() // IEnumerable<Z> // a //unmanaged // or struct // or class
        {
            public void SetItem(T item)
            {

            }
        }

        public class a { }
        public class b: a {
            private b()
            {

            }
            public static b Create()
            {
                return new b();
            }
        }
        public class c : a { }

        struct MyStruct
        {
            public int a;
            public int b;
            private int myVar;

            public int MyProperty
            {
                get { return myVar; }
                set { myVar = value; }
            }

            void Print()
            {

            }
        }

        public class PrintManager<T>
        {

        }

        public string func<FFF, Y>(FFF o, Y y)
        {
            string s = o.ToString() + " " + y.ToString();
            return s;
        }
    }
}
