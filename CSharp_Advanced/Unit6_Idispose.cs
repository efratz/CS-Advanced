using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Advanced
{
    internal class Unit6_Idispose
    {
        public void Run()
        {
            MakeBigRequest makeBigRequest = new MakeBigRequest();
            makeBigRequest.Operate();

            // relesase resources
            // 1
            // makeBigRequest.Release();
            // 2
            // makeBigRequest.Dispose();
            // 3
            using (MakeBigRequest makeBigRequest1 = new MakeBigRequest())
            {
                makeBigRequest.Operate();
            }

            using (var f = System.IO.File.Open("", System.IO.FileMode.Create))
            {

            }


        }
    }

    class MakeBigRequest : IDisposable
    {
        public void Dispose()
        {
            Release();
        }

        public void Operate()
        {
            // take huge memory

            // create temp DB
        }

        public void Release()
        {
            // drop temp DB


        }
    }
}
