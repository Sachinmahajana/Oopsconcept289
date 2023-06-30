namespace Oopsconcept289
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the oops concept program");
            Console.WriteLine("Please choose the proram given below");
            Console.WriteLine("\n1:Singleinheritance");
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
            }
        }
    }
}