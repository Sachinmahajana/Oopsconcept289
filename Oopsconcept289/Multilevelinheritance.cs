using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oopsconcept289
{
    public class Carinf
    {
        public string Name;
        public int Price;
        public string model;
        public void CarDetails()
        {
            Console.WriteLine("Car Name is:" + Name);
            Console.WriteLine("Car Price is:" + Price);
            Console.WriteLine("Car model is:" + model);
        }
    }
        public class Bmw : Carinf
        {
            public int speed;
            public void PrintSpeed()
            {
                Console.WriteLine("Car speed is:" + speed);
            }
        }
        public class Maruti : Bmw
        {
            public float Mileage;
            public void PrintMileage()
            {
                Console.WriteLine("Car Mileage is:" + Mileage);
            }
        }
    
}
