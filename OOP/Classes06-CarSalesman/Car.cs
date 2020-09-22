using System;
using System.Collections.Generic;
using System.Text;

namespace Classes06_CarSalesman
{
    public class Car
    {
        public string Model { get; set; }
        public Engine engine { get; set; }
        public int? Weight { get; set; }
        public string Color { get; set; }

        public Car(string model, Engine engine)
        {
            this.Model = model;
            this.engine = engine;
        }


        public Car(string model, Engine engine, int weight)
            : this(model, engine)
        {
            this.Weight = weight;
        }


        public Car(string model, Engine engine, string color)
            : this(model, engine)
        {
            this.Color = color;
        }


        public Car(string model, Engine engine, int weight, string color)
            : this(model, engine,weight)
        {
            this.Color = color;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            string weighting = this.Weight.HasValue ? this.Weight.ToString() : "n/a";

    //(IF weighting HAS VALUE (checking if int receives value or nullable), we give the value, else "n/a"


            string coloring = string.IsNullOrEmpty(this.Color) ? "n/a" : this.Color;


            sb
                .AppendLine($"{this.Model}:")
                .AppendLine($"  {this.engine}")
                .AppendLine($"  Weight: {weighting}")
                .AppendLine($"  Color: {coloring}");

            return sb.ToString().TrimEnd();
        }
    }
}
