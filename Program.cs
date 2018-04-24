using System;

namespace assignment1_part2
{
    class Program
    {
        static void Main(string[] args)
        {
            var newCar = new Car();
            Console.WriteLine("Enter new car details below");
            Console.Write("Colour: ");
            newCar.Colour = Console.ReadLine();

            Console.Write("Make: ");
            newCar.Make = Console.ReadLine();

            Console.Write("Gearbox type: ");
            newCar.Gearbox = Console.ReadLine();

            Console.WriteLine(newCar.DescribeCar());

            Console.ReadKey();
        }
    }

    class Car
    {
        public string Colour {get; set;}
        public string Make {get; set;}
        public string Gearbox {get; set;}

        public string DescribeCar()
        {
            return $"\nThis car is a {Colour} {Make} with a {Gearbox} transmission";
        }
    }
}
