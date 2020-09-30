using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsLEx02
{
    public class Box<T>
    {
        public T unit { get; set; }


        public Box(T unit)
        {
            this.unit = unit;
        }

        public override string ToString()
        {

            return $"{this.unit.GetType()}: {this.unit}";

        }

    }
}
