using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegates_and_events_tutorial
{
    public delegate void ChangeEventHandler(object sender, EventArgs e);
    public delegate void FizzBuzzEventHandler(object sender, EventArgs e);
    
    class ListWithChangedEvent : ArrayList
    {
        public ChangeEventHandler Changed;
        public FizzBuzzEventHandler fizz;
        public FizzBuzzEventHandler buzz;
        public FizzBuzzEventHandler fizzbuzz;
        protected virtual void OnChanged(EventArgs e)
        {
            if (Changed != null)
                Changed(this, e);
        }
        protected virtual void Onfizz(EventArgs e)
        {
            if (fizz != null)
            {
                fizz(this, e);
            }
        }
        protected virtual void Onbuzz(EventArgs e)
        {
            if (buzz != null)
            {
                buzz(this, e);
            }
        }
        protected virtual void Onfizzbuzz(EventArgs e)
        {
            if (fizzbuzz != null)
            {
                fizzbuzz(this, e);
            }
        }
        public override int remove(int index)
        {
            return base.remove(index);
        }


        public override int Add(object value)
        {
            int i = base.Add(value);
            OnChanged(EventArgs.Empty);
            return i;
        }
        public override void Clear()
        {
            base.Clear();
            OnChanged(EventArgs.Empty);
        }

        public override object this[int index]
        {
            set
            {
                base[index] = value;
                OnChanged(EventArgs.Empty);
            }
        }
        public void fizzBuzz()
        {
            for (int i = 0; i < Length; i++)
            {
                if ((int)this[i] %3 ==0 && (int)this[i] %5 ==0)
                {
                    Console.Write(this[i]);
                    Onfizzbuzz(EventArgs.Empty);
                }
                else if ((int)this[i] % 3 == 0)
                {
                    Console.Write(this[i]);
                    Onfizz(EventArgs.Empty);
                }
                else if ((int)this[i] % 5 == 0)
                {
                    Console.Write(this[i]);
                    Onbuzz(EventArgs.Empty);
                }
                else
                {
                    remove(i);
                    i--;
                }
            }
        }


    }
}
