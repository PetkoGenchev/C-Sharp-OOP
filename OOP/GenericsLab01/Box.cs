using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BoxOfT
{
    public class Box<T>
    {
        public Stack<T> data;

        public Box()
        {
            this.data = new Stack<T>();
        }

        int Count
        {
            get
            {
                return this.data.Count;
            }
        }

        public void Add(T item)
        {
            this.data.Push(item);
        }

        public T Remove()
        {
            return this.data.Pop();
        }

    }
}
