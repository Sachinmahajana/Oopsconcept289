﻿using static Oopsconcept289.Encapsulation;

namespace Oopsconcept289
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the oops concept program");
            Console.WriteLine("Please choose the proram given below");
            Console.WriteLine("\n1:Singleinheritance\n2:Multilevelinheritance\n3:MethodOverloading\n4:Methodoverriding\n5:Abstration\n6:Encapsulation");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Toyota car = new Toyota();
                    car.name = "Toyota Glanza";
                    car.model = "Glanza S Amt";
                    car.price = 815000;
                    car.mileage = 22.94f;
                    car.CarDetails();
                    car.PrintMileage();
                    break;
                case 2:
                    Maruti cars = new Maruti();
                    cars.Name = "Celrio";
                    cars.Price = 600000;
                    cars.model = "Vxi";
                    cars.speed = 100;
                    cars.Mileage = 25.5f;
                    cars.CarDetails();
                    cars.PrintMileage();
                    cars.PrintSpeed();
                    break;
                case 3:
                    Programs Obj = new Programs();
                    Obj.Add(12, 2);
                    break;
                case 4:
                    Dog tommy = new Dog();
                    tommy.Eat();
                    break;
                case 5:
                    ParttimeEmployee empn = new ParttimeEmployee();
                    empn.GetSalary();
                    break;
                case 6:
                    A g = new A();
                    g.SetValue(4567);
                    Console.WriteLine("ATM PIN:" + g.GetReturn());
                    break;
                case 7:
                    PartTimeemployee pte = new PartTimeemployee();
                    pte.show();
                    pte.show2();
                    break;
            }
        }
    }
}