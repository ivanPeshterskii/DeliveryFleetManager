using System;
using System.Collections.Generic;
using DeliveryFleetManager.VanInformation;

namespace DeliveryFleetManager
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, Van> vans = new Dictionary<string, Van>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split('|');
                string name = input[0];
                int mileage = int.Parse(input[1]);
                int fuel = int.Parse(input[2]);

                vans[name] = new Van(name, mileage, fuel);
            }

            string command;
            while ((command = Console.ReadLine()) != "Shutdown")
            {
                string[] parts = command.Split(" : ");
                string action = parts[0];
                string vanName = parts[1];

                if (!vans.ContainsKey(vanName))
                    continue;

                Van van = vans[vanName];

                switch (action)
                {
                    case "Deliver":
                        int distance = int.Parse(parts[2]);
                        int fuel = int.Parse(parts[3]);

                        
                        string deliveryResult = van.Deliver(distance, fuel);
                        Console.WriteLine(deliveryResult);

                        if (van.Mileage >= 150000)
                        {
                            Console.WriteLine($"Van {van.Name} is decommissioned");
                            vans.Remove(vanName);
                        }

                        break;

                    case "Refuel":
                        int refuelAmount = int.Parse(parts[2]);
                        string refuelResult = van.Refuel(refuelAmount);
                        Console.WriteLine(refuelResult);
                        break;

                    case "Service":
                        int kilometers = int.Parse(parts[2]);
                        string serviceResult = van.Service(kilometers);
                        if (!string.IsNullOrEmpty(serviceResult))
                        {
                            Console.WriteLine(serviceResult);
                        }
                        break;
                }
            }

            foreach (var van in vans.Values)
            {
                Console.WriteLine(van);
            }
        }
    }
}
