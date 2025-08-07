using System;

namespace DeliveryFleetManager.VanInformation
{
    public class Van
    {
        public string Name { get; set; }
        public int Mileage { get; private set; }
        public int Fuel { get; private set; }

        private const int MaxFuel = 100;
        private const int MinMileage = 5000;
        private const int MaxMileage = 150000;

        public Van(string name, int mileage, int fuel)
        {
            Name = name;
            Mileage = mileage;
            Fuel = fuel;
        }

        public string Deliver(int distance, int fuelNeeded)
        {
            

            if (Fuel < fuelNeeded)
            {
                return "Insufficient fuel for the delivery";
            }

            Mileage += distance;
            Fuel -= fuelNeeded;

            string message = $"Delivery van {Name} drove {distance} km using {fuelNeeded} liters";

            if (Mileage >= MaxMileage)
            {
                
                message += $"\nVan {Name} is decommissioned";
            }

            return message;
        }

        public string Refuel(int fuelAmount)
        {
            int fuelBefore = Fuel;
            int fuelAdded = Math.Min(fuelAmount, MaxFuel - Fuel);
            Fuel += fuelAdded;

            return $"Van {Name} refueled with {fuelAdded} liters";
        }

        public string Service(int km)
        {
            int oldMileage = Mileage;
            Mileage -= km;

            if (Mileage < MinMileage)
            {
                Mileage = MinMileage;
                return "";
            }

            int reducedBy = oldMileage - Mileage;
            return $"Van {Name} mileage decreased by {reducedBy} km";
        }

        public override string ToString()
        {
            return $"{Name} -> Mileage: {Mileage} km, Fuel: {Fuel} lt.";
        }
    }
}