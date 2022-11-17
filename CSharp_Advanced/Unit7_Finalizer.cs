using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Advanced
{
    internal class Unit7_Finalizer
    {
        FileStream fs;
        public void Run()
        {
            try
            {
                fs = System.IO.File.OpenRead("");
            }
            catch (Exception ex)
            {

            }
            finally
            {
                fs.Close();
            }


            // fs.Close();
        }

        public Unit7_Finalizer()
        {
            // constructor
        }

        ~Unit7_Finalizer()
        {
            // desctuctor
            // finalizer
            fs.Close();
        }

    }
}
