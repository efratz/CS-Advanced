using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Advanced
{
    public class Unit3_Struct
    {
        int a;
        void run()
        {
            Unit3_TheRealStruct stru;
            Unit3_TheRealStruct[] str = new Unit3_TheRealStruct[100];
            stru.a = 123;
        }
    }


    // located on stack
    struct Unit3_TheRealStruct
    {
        public int a;
        public int b;
        // located on Heap
        public Label l;
        int c;
        public int Run()
        {
            return 12;
        }
    }
}
