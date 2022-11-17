using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Advanced
{
    public class Unit2_Foreach
    {
        public void Run()
        {
            LinkedList<string> list = new LinkedList<string>();
            var a = list.ToArray();
            for (int i = 0; i < a.Length; i++)
            {

            }

            int[] arr = new int[100];
            int sum = 0;
            foreach (int i in arr)
            {
                sum += i;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }


        }

        public void RumMyItems()
        {
            Items items = new Items();
            string allStr = "";
            foreach (var item in items)
            {
                allStr += item.ToString();
            }
        }
    }

    public class Items : IEnumerable, IEnumerator
    {
        public string[] list = { "ball", "shirt", "CD", "TV" };
        int idx = -1;
        // public object Current => list[idx];
        public object Current
        {
            get
            {
                if (idx == 0)
                {
                    return "start";
                }
                else
                {
                    return list[idx];
                }
            }
        }

        public IEnumerator GetEnumerator()
        {
            return this;
        }

        public bool MoveNext()
        {
            // condition
            if (idx < list.Length - 1)
            {
                idx++;
                return true;
            }
            // jump to next position
            return false;
        }

        public void Reset()
        {
            idx = -1;
        }
    }
}
