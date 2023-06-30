using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oopsconcept289
{
    public class Car
    {
        public string name;
        public string model;
        public int price;
        public void CarDetails()
        {
            Console.WriteLine("Car Name is:" + name);
            Console.WriteLine("Car Model is:" + model);
            Console.WriteLine("Car Price is:" + price);
        }
    }
    public class Toyota : Car
    {
        public float mileage;
        public void PrintMileage()
        {
            Console.WriteLine("Car Mileage is:" + mileage);
        }
    }
}
