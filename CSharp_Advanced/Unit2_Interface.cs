using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Advanced
{
    public interface ITax
    {
        int Maam(int price);
        int IncomminTax(int price);
    }

    public interface INewTax:ITax
    {

    }

    public interface ICar
    {

    }

    public class Eilat : ITax, ICar
    {
        public int IncomminTax(int price)
        {
            return 0;
        }

        public int Maam(int price)
        {
            return 0;
        }
    }

    public class Regolar : ITax
    {
        public int IncomminTax(int price)
        {
            return price * 3;
        }

        public int Maam(int price)
        {
            return price * 3;
        }

        public int GetSum()
        {
            return 100;
        }
    }

    public class InterfaceSamples
    {
        public void Run()
        {
            ITax[] arr = new ITax[10];
            arr[0] = new Eilat();
            arr[1] = new Regolar();

            arr[0].Maam(10);
            arr[0].IncomminTax(10);

            Eilat e1 = new Eilat();
            Test(e1);
        }

        public void Test(ITax a)
        {

        }
        public void TestCar(ICar a)
        {

        }

    }
}
