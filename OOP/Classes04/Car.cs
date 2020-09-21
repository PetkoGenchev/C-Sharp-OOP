using System;
using System.Collections.Generic;
using System.Text;

namespace Classes04
{
    public class Car
    {
        private string model;
        private double fuelAmount;
        private double fuelConsumptionPerKilometer;
        private double travelledDistance;

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                this.model = value;
            }
        }

        public double FuelAmount
        {
            get
            {
                return this.fuelAmount;
            }
            set
            {
                this.fuelAmount = value;
            }
        }

        public double FuelConsumptionPerKilometer
        {
            get
            {
                return this.fuelConsumptionPerKilometer;
            }
            set
            {
                this.fuelConsumptionPerKilometer = value;
            }
        }

        public double TravelledDistance
        {
            get
            {
                return this.travelledDistance;
            }
            set
            {
                this.travelledDistance = value;
            }
        }

        public Car(string model, double fuelAmount, double fuelConsumptionPerKilometer)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
            this.travelledDistance = 0;
        }

        public void What(int kilometersToUse)
        {
            bool canTravel = this.fuelAmount - (kilometersToUse * this.fuelConsumptionPerKilometer) >= 0;

            if (canTravel)
            {
                this.fuelAmount -= kilometersToUse * this.fuelConsumptionPerKilometer;
                this.travelledDistance += kilometersToUse;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }

        public override string ToString()
        {
            return $"{this.model} {this.fuelAmount:F2} {this.travelledDistance}";
        }
    }
}
