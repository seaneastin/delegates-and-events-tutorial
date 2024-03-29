﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegates_and_events_tutorial
{
    class ArrayList
    {
        private object[] _list;

        public ArrayList()
        {
            _list = new object[0];
        }

        public virtual int remove(int index)
        {
            object[] newList = new object[_list.Length - 1];
            int newPosition = 0;
            for (int i = 0; i < _list.Length; i++)
            {
                if (i != index)
                {
                    newList[newPosition] = _list[i];
                newPosition++;
                }
                
            }
            _list = newList;
            int j = 0;
            return j;
        }

        public virtual int Add(object value)
        {
            object[] newList = new object[_list.Length + 1];
            for (int i = 0; i < _list.Length; i++)
            {
                newList[i] = _list[i];
            }
            //Put the new value at the end of the new array
            newList[newList.Length - 1] = value;

            _list = newList;
            int j = 0;
            return j;
        }
        public virtual void Clear()
        {
            _list = new object[0];
        }

        public virtual object this[int index]
        {
            set
            {
                _list[index] = value;
            }
            get
            {
                return _list[index];
            }
        }
        public void print()
        {
            foreach(object i in _list)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        public int Length
        {
            get
            {
                return _list.Length;
            }
        }

    }
}
