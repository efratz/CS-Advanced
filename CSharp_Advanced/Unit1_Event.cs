using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Advanced
{
    internal class Unit1_Event
    {
        public delegate void TimeOut_func(int time);
        public event TimeOut_func TimeOut_handler;

        public void Run()
        {
            // broadcast events to all listeners
            if (TimeOut_handler != null)
                TimeOut_handler(1200);
        }
    }

    public class Operate
    {
        Unit1_Event unit1_event = new Unit1_Event();
        DB db = new DB();
        UI ui = new UI();

        public void Init()
        {
            // register to broadcast list
            unit1_event.TimeOut_handler += db.UpdateDBAfterTimeOut;
            unit1_event.TimeOut_handler += ui.UpdateUIAfterTimeOut;

            unit1_event.Run();

            // unregister from broadcast list
            unit1_event.TimeOut_handler -= ui.UpdateUIAfterTimeOut;
            unit1_event.Run();

        }
    }

    public class DB
    {
        public void UpdateDBAfterTimeOut(int time)
        {

        }
    }

    public class UI
    {
        public void UpdateUIAfterTimeOut(int time)
        {

        }
    }
}
