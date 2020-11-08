using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Parking
{
    public class Parking
    {
        private List<Car> data;
        public string Type { get; set; }
        public int Capacity { get; set; }


        public int Count => data.Count;

        public Parking(string type, int capacity)
        {
            this.Type = type;
            this.Capacity = capacity;
            data = new List<Car>();
        }

        public void Add(Car car)
        {
            if (Capacity > Count)
            {
                data.Add(car);
            }
        }

        public bool Remove(string manufacturer, string model)
        {
            Car manufacturerToRemove = data.FirstOrDefault(x => x.Manufacturer == manufacturer);
            Car modelToRemove = data.FirstOrDefault(x => x.Model == model);
                return data.Remove(modelToRemove);

        }

        public Car GetLatestCar()
        {
            if (Count == 0)
            {
                return null;
            }
            else
            {
                Car GetLatestCar = data.OrderByDescending(x => x.Year).FirstOrDefault();
                return GetLatestCar;
            }
        }


        public Car GetCar(string manufacturer, string model)
        {
            var carToGet = data.FirstOrDefault(x => (x.Manufacturer == manufacturer && x.Model == model));
            return carToGet;
        }


        public string GetStatistics()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"The cars are parked in {this.Type}");

            foreach (var car in data)
            {
                sb.AppendLine(car.ToString());
            }

            return sb.ToString().TrimEnd();
        }

    }
}
