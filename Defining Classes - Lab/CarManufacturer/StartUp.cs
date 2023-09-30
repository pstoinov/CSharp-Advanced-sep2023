using System;
using System.Collections.Generic;
using System.Linq;

namespace CarManufacturer
{
    class Program
    {
        static void Main(string[] args)
        {
            List<List<double>> listTiresYears = new List<List<double>>();
            List<List<double>> listTiresPressures = new List<List<double>>();
            List<int> listHorsePowers = new List<int>();
            List<double> listCubicCapacity = new List<double>();

            List<Car> listCars = new List<Car>();



            Tires tires = new Tires();
            Engine engine = new Engine();
            string input;
            while ((input = Console.ReadLine()) != "No more tires")
            {
                string[] splitted = input.Split();

                List<double> listYears = tires.GetYearInfo(splitted);
                List<double> listPressures = tires.GetPressureInfo(splitted);

                listTiresYears.Add(listYears);
                listTiresPressures.Add(listPressures);

            }

            

            while ((input = Console.ReadLine()) != "Engines done")
            {
                string[] splitted = input.Split();

                listHorsePowers.Add(engine.GetHorsePower(splitted));
                listCubicCapacity.Add(engine.GetCubicCapacity(splitted));

            }


            while ((input = Console.ReadLine()) != "Show special")
            {
                string[] splitted = input.Split();
                string make = splitted[0];
                string model = splitted[1];
                int year = int.Parse(splitted[2]);
                double fuelQuantity = double.Parse(splitted[3]);
                double fuelConsumption = double.Parse(splitted[4]);
                int engineIndex = int.Parse(splitted[5]);
                int tiresIndex = int.Parse(splitted[6]);

                int horsePower = listHorsePowers[engineIndex];
                double pressure = tires.GetSumPressure(listTiresPressures, tiresIndex);

                Car car = new Car(make, model, year, horsePower, fuelQuantity, fuelConsumption,
                    engineIndex, tiresIndex, pressure);

                listCars.Add(car);


            }

            foreach (var car in listCars)
            {
                if (car.Year >= 2017 && car.HorsePower > 330
                    && car.TotalPressure > 9 && car.TotalPressure < 10)
                {
                    car.FuelQuantity = car.Drive20Kilometers(car.FuelQuantity, car.FuelConsumption);

                    Console.WriteLine($"Make: {car.Make}");

                    Console.WriteLine($"Model: {car.Model}");

                    Console.WriteLine($"Year: {car.Year}");

                    Console.WriteLine($"HorsePowers: {car.HorsePower}");

                    Console.WriteLine($"FuelQuantity: {car.FuelQuantity}");
                }
            }
            //Car car = new Car();

            //string make = Console.ReadLine();
            //string model = Console.ReadLine();
            //int year = int.Parse(Console.ReadLine());
            //double fuelQuantity = double.Parse(Console.ReadLine());
            //double fuelConsumption = double.Parse(Console.ReadLine());

            //Car firstCar = new Car();
            //Car secondCar = new Car(make, model, year);
            //Car thirdCar = new Car(make, model, year, fuelQuantity, fuelConsumption);

            //Engine threeLitreDiesel = new Engine(215, 3);
            //Tire[] tires = new Tire[4]
            //{
            //   new Tire(2020,200),
            //   new Tire(2020,200),
            //   new Tire(2020,200),
            //   new Tire(2020,200),
            //};
            //car.Make = "VW";
            //car.Model = "Golf";
            //car.Year = 2006;
            //car.FuelQuantity = 200;
            //car.FuelConsumption = 5;

            //car.Drive(20);
            //Console.WriteLine(car.WhoAmI());
        }
    }
}
