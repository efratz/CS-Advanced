using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Advanced
{
    internal class Unit3_StackHeap
    {
        public void Run()
        {
            // Created on Heap
            Label l = new Label(); // l - Stack, new Label() - Heap
            int[] arr = new int[100]; // 404 bytes
        } // Deleted
    }
}
