using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oopsconcept289
{
    public class Animal
    {
       public void Eat()
       {
            Console.WriteLine("Animal is eating");
       }
    }
    public class Dog : Animal
    {
        public void Eat()
        {
            Console.WriteLine("Dog is Eating");
        }
    }  
}
