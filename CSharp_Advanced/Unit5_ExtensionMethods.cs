using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Advanced
{
    internal class Unit5_ExtensionMethods
    {
        public void Run()
        {
            string s = "ssd.fytyt.trr.xcbjui.5yghy8.dtr";
            int a = Utilities.DotsCounter(s);
            // MyString str = "ssd.fytyt.trr.xcbjui.5yghy8.dtr";

            a = s.DotsCounter();

            Car car = new Car();
            car.HasMobily(2022);
        }        
    }
    
    public static class ExtStringMethods
    {
        public static int DotsCounter(this string str)
        {
            return str.Split('.').Count() - 1;
        }

        public static bool HasMobily(this Car car, int year)
        {
            if(year>=2022)
            { return true; }
            if(car.GetPrice() > 90000)
            {
                return true;
            }
            return false;
        }
    }

    public class Car
    {
        public int GetPrice()
        {
            return 100000;
        }
    }

    /* public class MyString:string
    {
        public int DotsCounter(string str)
        {
            return str.Split('.').Count() - 1;
        }
    } */
    public class Utilities
    {
        public static int DotsCounter(string str)
        {
            return str.Split('.').Count() - 1;
        }
    }

  
}
