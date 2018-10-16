using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Pattern
{
    class Program
    {
        public enum TemperatureType
        {
            Fahrenheit,
            Celsius
        }

        class MeatDatabase
        {
            public float GetSafeCookTemp(string meat, TemperatureType tempType)
            {
                if (tempType == TemperatureType.Fahrenheit)
                {
                    switch(meat)
                    {
                        case "beef":
                        case "pork":
                            return 145f;
                        case "chicken":
                        case "turkey":
                            return 165f;
                        default:
                            return 165;
                    }
                }
                else
                {
                    switch (meat)
                    {
                        case "beef":
                        case "veal":
                        case "pork":
                            return 63f;
                        case "chicken":
                        case "turkey":
                            return 74f;
                        default:
                            return 74f;
                    }
                }
            }
            public int GetCaloriesPerOunce(string meat)
            {
                switch (meat.ToLower())
                {
                    case "beef": return 71;
                    case "pork": return 69;
                    case "chicken": return 66;
                    case "turkey": return 38;
                    default: return 0;
                }
            }

            public double GetProteinPerOunce(string meat)
            {
                switch (meat.ToLower())
                {
                    case "beef": return 7.33f;
                    case "pork": return 7.67f;
                    case "chicken": return 8.57f;
                    case "turkey": return 8.5f;
                    default: return 0d;
                }
            }

            class Meat
            {
                protected string MeatName;
                protected float SafeCookTempFahrenheit;
                protected float SafeCookTempCelsius;
                protected double CaloriesPerOunce;
                protected double ProteinPerOunce;

                public Meat(string meat)
                {
                    MeatName = meat;
                }

                public virtual void LoadData()
                {
                    Console.WriteLine("\nMeat: {0} ----- ", MeatName);
                }
            }
            class MeatDetails : Meat
            {
                private MeatDatabase _meatDatabase;

                public MeatDetails(string name)
                    : base(name) { }

                public override void LoadData()
                {
                    //The Adaptee
                    _meatDatabase = new MeatDatabase();

                    SafeCookTempFahrenheit = _meatDatabase.GetSafeCookTemp(MeatName, TemperatureType.Fahrenheit);
                    SafeCookTempCelsius = _meatDatabase.GetSafeCookTemp(MeatName, TemperatureType.Celsius);

                    CaloriesPerOunce = _meatDatabase.GetCaloriesPerOunce(MeatName);
                    ProteinPerOunce = _meatDatabase.GetProteinPerOunce(MeatName);

                    base.LoadData();
                    Console.WriteLine(" Safe Cook Temp (F): {0}", SafeCookTempFahrenheit);
                    Console.WriteLine(" Safe Cook Temp (C): {0}", SafeCookTempCelsius);
                    Console.WriteLine(" Calories per Ounce: {0}", CaloriesPerOunce);
                    Console.WriteLine(" Protein per Ounce: {0}", ProteinPerOunce);
                }
            }
            static void Main(string[] args)
            {
                //Non-adapted
                Meat unknown = new Meat("Beef");
                unknown.LoadData();

                //Adapted
                MeatDetails beef = new MeatDetails("Beef");
                beef.LoadData();

                MeatDetails turkey = new MeatDetails("Turkey");
                turkey.LoadData();

                MeatDetails chicken = new MeatDetails("Chicken");
                chicken.LoadData();

                Console.ReadKey();
            }

        }
    }
}
