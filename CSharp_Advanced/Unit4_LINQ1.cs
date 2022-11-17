using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Advanced
{
    internal class Unit4_LINQ1
    {
        Unit4_LINQ2.Product product = new Unit4_LINQ2.Product();

        void Run1()
        {
            int[] nums = { 165, 2, 73, 55, 4, 6, -84, 8, 2, 54, 6 };

            // select *
            // from tbl
            // where condition
            foreach(int x in nums)
            {

            }
            var list = from x in nums
                       where x > 10
                       select x;

            var list2 = from y in list
                        where y < 100
                        select y;

        }
    }
}
