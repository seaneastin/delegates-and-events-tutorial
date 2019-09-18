using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegates_and_events_tutorial
{
    class EventListener
    {
        private ListWithChangedEvent List;

        public EventListener(ListWithChangedEvent list)
        {
            List = list;
            List.Changed += new ChangeEventHandler(OnListChanged);

            list.fizz += new FizzBuzzEventHandler(OnFizzFound);
        }
        private void OnListChanged(object sender, EventArgs e)
        {
            Console.WriteLine("list changed event received");
        }
        public void Detatch()
        {
            List.Changed -= new ChangeEventHandler(OnListChanged);
            List = null;
        }
        private void OnFizzFound(object sender, EventArgs e)
        {
            Console.WriteLine(" Fizz");
        }
        private void OnBuzzFound(object sender, EventArgs e)
        {
            Console.WriteLine(" Buzz");
        }
        private void OnFizzBuzzFound(object sender, EventArgs e)
        {
            Console.WriteLine(" FizzBuzz");
        }
        private void print()
        {
            List.print();
        }

    }
}
