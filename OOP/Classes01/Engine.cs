using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    public class Engine
    {
        public int HorsePower { get; }
        public double CubicCapacity { get; }

        public Engine(int horsePower, double cubicCapacity)
        {
            if (horsePower <= 0 || cubicCapacity <= 0)
            {
                throw new InvalidOperationException("Wrong Entry!");
            }

            this.HorsePower = horsePower;
            this.CubicCapacity = cubicCapacity;
        }
    }
}
