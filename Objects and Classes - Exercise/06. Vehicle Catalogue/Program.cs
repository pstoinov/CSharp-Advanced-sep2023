using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Vehicle_Catalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            string command;
            while ((command = Console.ReadLine()) !="End")
            {
                string[] tokens = command.Split();
                string type = tokens[0];
                string model = tokens[1];
                string color = tokens[2];
                string horsePower = tokens[3];

                Vehicle vehicle = new Vehicle(type, model, color, horsePower);
                vehicles.Add(vehicle);

            }

            while ((command = Console.ReadLine()) != "Close the Catalogue")
            {
                string model = command;
                Vehicle founVehicle = vehicles.FirstOrDefault(x => x.Model == model);
                if (founVehicle != null) {
                    Console.WriteLine(founVehicle);
                }

            }
            decimal averageHP = vehicles
                .Where(vehicle => vehicle.Type == Type.Car)
                .Select(vehicle => vehicle.HP)
                .DefaultIfEmpty()
                .Average();
            Console.WriteLine($"Cars have average horsepower of: {averageHP:F2}.");

            averageHP = vehicles
                .Where(vehicle => vehicle.Type == Type.Truck)
                .Select(vehicle => vehicle.HP)
                .DefaultIfEmpty()
                .Average();
            Console.WriteLine($"Trucks have average horsepower of: {averageHP:F2}.");
        }
        enum Type
        {
            Car,
            Truck
        }

        class Vehicle
        {
            public Type Type { get; set; }
            public string Model { get; set; }
            public string Color { get; set; }
            public decimal HP { get; set; }

            public Vehicle(string type, string model, string color, string hp)
            {
                Type = type == "car" ? Type.Car : Type.Truck;
                Model = model;
                Color = color;
                HP = decimal.Parse(hp);
            }

            public override string ToString()
            {
                return $"Type: {Type}\n" +
                       $"Model: {Model}\n" +
                       $"Color: {Color}\n" +
                       $"Horsepower: {HP}";
            }
        }
    }
}
