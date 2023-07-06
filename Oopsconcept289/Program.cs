namespace Oopsconcept289
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the oops concept program");
            Console.WriteLine("Please choose the proram given below");
            Console.WriteLine("\n1:Singleinheritance\n2:Multilevelinheritance\n3:MethodOverloading\n4:Methodoverriding");
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
            }
        }
    }
}