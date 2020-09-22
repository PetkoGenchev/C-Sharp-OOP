using System;
using System.Collections.Generic;
using System.Text;

namespace Classes06_CarSalesman
{
    public class Engine
    {
        public string Model { get; set; }
        public int Power { get; set; }
        public int? Displacement { get; set; }
        public string Efficiency { get; set; }

        public Engine(string model, int power)
        {
            this.Model = model;
            this.Power = power;
        }

        public Engine(string model, int power, string efficiency)
            :this(model,power)
        {
            this.Efficiency = efficiency;
        }

        public Engine(string model, int power, int displacement)
        : this(model, power)
        {
            this.Displacement = displacement;
        }

        public Engine(string model, int power, int displacement, string efficiency)
        : this(model, power,displacement)
        {
            this.Efficiency = efficiency;
        }

        public override string ToString()
        {

            string discplacing = this.Displacement.HasValue ? this.Displacement.ToString() : "n/a";
            string efficient = string.IsNullOrEmpty(this.Efficiency) ? "n/a" : this.Efficiency;


            StringBuilder sb = new StringBuilder();

            sb
                .AppendLine($"{this.Model}:")
                .AppendLine($"  Power: {this.Power}:")
                .AppendLine($"  Displacement: {discplacing}")
                .AppendLine($"  Efficiency: {efficient}");

            return sb.ToString().TrimEnd();
        }


    }
}
