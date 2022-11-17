using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Advanced
{
    public class Unit1_Tuple
    {
        public void Run()
        {
            var var1 = CreateNewTuple();
        }

        (int id, string fname, string lname) CreateNewTuple()
        {
            (int id, string fname, string lname) newPerson;
            int num = 123345698;
            string firstName = "MiMi";
            string lastName = "Levi";

            newPerson = (num, firstName, lastName);
            newPerson.lname = "Cohen";
            return newPerson;
        }
    }
}
