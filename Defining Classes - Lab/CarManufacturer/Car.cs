using System;
namespace CarManufacturer
{
    public class Car
    {
        private string make;
        private string model;
        private int year;
        private double fuelQuantity;
        private double fuelConsumption;
        private int engineIndex;
        private int tiresIndex;


        public Car(string make, string model, int year, int horsePower, double fuelQuantity,
            double fuelConsumption, int engineIndex, int tiresIndex, double totalPressure)
        {
            Make = make;
            Model = model;
            Year = year;
            HorsePower = horsePower;
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
            EngineIndex = engineIndex;
            TiresIndex = tiresIndex;
            TotalPressure = totalPressure;
        }


        public string Make { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }

        public int HorsePower { get; set; }

        public double FuelQuantity { get; set; }

        public double FuelConsumption { get; set; }

        public int EngineIndex { get; set; }

        public int TiresIndex { get; set; }

        public double TotalPressure { get; set; }


        public double Drive20Kilometers(double fuelQuantity, double fuelConsumption)
        {
            fuelQuantity -= (FuelConsumption / 100) * 20;

            return fuelQuantity;
        }
    }
    public class Engine
    {
        public int HorsePower { get; set; }

        public double CubicCapacity { get; set; }



        public int GetHorsePower(string[] splitted)
        {
            int horsePower = int.Parse(splitted[0]);

            return horsePower;
        }

        public double GetCubicCapacity(string[] splitted)
        {
            double cubicCapacity = double.Parse(splitted[1]);

            return cubicCapacity;
        }
    }
    public class Tires
    {
        private int year;
        private double pressure;


        public int Year { get; set; }

        public double Pressure { get; set; }


        public List<double> GetYearInfo(string[] splitted)
        {
            List<double> listYears = new List<double>();

            for (int i = 0; i < splitted.Length; i += 2)
            {
                listYears.Add(int.Parse(splitted[i]));
            }

            return listYears;
        }

        public List<double> GetPressureInfo(string[] splitted)
        {
            List<double> listPressure = new List<double>();

            for (int i = 1; i < splitted.Length; i += 2)
            {
                listPressure.Add(double.Parse(splitted[i]));
            }

            return listPressure;
        }

        public double GetSumPressure(List<List<double>> listTiresPressures,
            int tiresIndex)
        {
            double sumPressure = listTiresPressures[tiresIndex].Sum();

            return sumPressure;
        }
    }
}
