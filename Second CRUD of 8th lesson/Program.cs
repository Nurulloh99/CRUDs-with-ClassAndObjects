using Second_CRUD_of_8th_lesson.Models;
using Second_CRUD_of_8th_lesson.Services;
using System.Linq;

namespace Second_CRUD_of_8th_lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RunFrontEnd();
        }


        public static void RunFrontEnd()
        {
            var carService = new CarsServices();

            while (true)
            {

                Console.WriteLine("1. Adding car");
                Console.WriteLine("2. Removing car");
                Console.WriteLine("3. Updating car");
                Console.WriteLine("4. Get All info of car");
                Console.WriteLine("5. Get by ID of car\n");
                Console.Write("Enter your option >> ");
                var option = int.Parse(Console.ReadLine());

                var carDetails = new Cars();

                switch (option)
                {
                    case 1:


                        Console.Write("Enter car model >> ");
                        carDetails.Model = Console.ReadLine();
                        Console.Write("Enter car Year >> ");
                        carDetails.Year = int.Parse(Console.ReadLine());
                        Console.Write("Enter car BuiltPlace >> ");
                        carDetails.BuiltPlace = Console.ReadLine();
                        Console.Write("Enter car Owner >> ");
                        carDetails.Owner = Console.ReadLine();
                        Console.Write("Enter car Description >> ");
                        carDetails.Description = Console.ReadLine();
                        Console.Write("Enter car Colour >> ");
                        carDetails.Colour = Console.ReadLine();

                        carService.AddedCars(carDetails);

                        break;

                    case 2:

                        Console.Write("Enter ID of car >> ");
                        var carsId = Guid.Parse(Console.ReadLine());
                        var removedCar = carService.DeletedCars(carsId);
                        Console.WriteLine(removedCar);

                        break;

                    case 3:

                        Console.Write("Enter car ID: ");
                        carDetails.Id = Guid.Parse(Console.ReadLine());
                        Console.Write("Enter car model >> ");
                        carDetails.Model = Console.ReadLine();
                        Console.Write("Enter car Year >> ");
                        carDetails.Year = int.Parse(Console.ReadLine());
                        Console.Write("Enter car BuiltPlace >> ");
                        carDetails.BuiltPlace = Console.ReadLine();
                        Console.Write("Enter car Owner >> ");
                        carDetails.Owner = Console.ReadLine();
                        Console.Write("Enter car Description >> ");
                        carDetails.Description = Console.ReadLine();
                        Console.Write("Enter car Colour >> ");
                        carDetails.Colour = Console.ReadLine();

                        carService.UpdatedCars(carDetails);

                        break;

                    case 4:

                        var result = carService.GetAllCars();

                        foreach (var check in result)
                        {
                            string inform = $"Cars ID: {check.Id}, Cars model {check.Model}, Cars Year {check.Year}, Cars built place {check.BuiltPlace}, " +
                                $" Cars owner {check.Owner}, Cars description {check.Description}, Cars color {check.Colour}";
                            Console.WriteLine(inform);
                        }
                        break;

                    case 5:

                        Console.Write("Enter ID which you want >> ");
                        var consolIn = Guid.Parse(Console.ReadLine());
                        var resulting = carService.GetById(consolIn);

                        string info = $"Cars ID: {resulting.Id}, Cars model {resulting.Model}, Cars Year {resulting.Year}, Cars built place {resulting.BuiltPlace}, " +
                                $" Cars owner {resulting.Owner}, Cars description {resulting.Description}, Cars color {resulting.Colour}";
                        Console.WriteLine(info);

                        break;

                }
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
