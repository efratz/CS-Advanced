using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;


namespace CSharp_Advanced
{
    public class Unit3_Nullable
    {
        public void Val()
        {
            //System.ValueType vs Object
            int a;
            // a = null; //not nullable

            int? b;
            b = null;

            if (b == null)
            {
            }
            if (b is null)
            { }
            if (b.HasValue)
            { }

            b = 3;
            a = b ?? = 2;

            Label? l = null;
            l ?? = new Label();

            if (l == null)
            {
                l = new Label();
            }
        }
    }
}