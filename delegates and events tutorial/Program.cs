using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegates_and_events_tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a new list
            ListWithChangedEvent list = new ListWithChangedEvent();

            //create a class that listens for when the lsit is changed
            EventListener listener = new EventListener(list);

            list.Add("hello");
            list.Add("world");
            list.Clear();
            listener.Detatch();

            Console.ReadKey();
        }
    }
}
