using First_CRUD_of_8th_lesson.Models;
using First_CRUD_of_8th_lesson.Services;
using System.Threading.Channels;

namespace First_CRUD_of_8th_lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RunFrontEnd();
        }


        public static void RunFrontEnd()
        {
            var StudentService = new StudentServices();

            while (true)
            {
                Console.WriteLine("1. Adding student info");
                Console.WriteLine("2. Removing student info");
                Console.WriteLine("3. Updating student info");
                Console.WriteLine("4. Get info by index");
                Console.WriteLine("5. Get all info");
                Console.Write("\nEnter one of your option >> ");
                var option = int.Parse(Console.ReadLine());

                var partOfProject = new Student();

                switch (option)
                {
                    case 1:

                        Console.Write("Enter Name: ");
                        partOfProject.Name = Console.ReadLine();
                        Console.Write("Enter Surname: ");
                        partOfProject.Surname = Console.ReadLine();
                        Console.Write("Enter Age: ");
                        partOfProject.Age = int.Parse(Console.ReadLine());
                        Console.Write("Enter Status: ");
                        partOfProject.Status = Console.ReadLine();
                        Console.Write("Enter BirthPlace: ");
                        partOfProject.BirthPlace = Console.ReadLine();
                        Console.Write("Enter BirthDay: ");
                        partOfProject.BirthDay = int.Parse(Console.ReadLine());
                        Console.Write("Enter LivingPlace: ");
                        partOfProject.LivingPlace = Console.ReadLine();

                        var addingInformation = StudentService.AddingStudent(partOfProject);
                        
                        break;


                    case 2:

                        Console.Write("Enter ID for removing >> ");
                        var id = Guid.Parse(Console.ReadLine());
                        var removed = StudentService.DeletedStudent(id);
                        Console.WriteLine(removed);

                        break;

                    case 3:


                        Console.Write("Enter ID of Student: ");
                        partOfProject.Id = Guid.Parse(Console.ReadLine());
                        Console.Write("Enter Name: ");
                        partOfProject.Name = Console.ReadLine();
                        Console.Write("Enter Surname: ");
                        partOfProject.Surname = Console.ReadLine();
                        Console.Write("Enter Age: ");
                        partOfProject.Age = int.Parse(Console.ReadLine());
                        Console.Write("Enter Status: ");
                        partOfProject.Status = Console.ReadLine();
                        Console.Write("Enter BirthPlace: ");
                        partOfProject.BirthPlace = Console.ReadLine();
                        Console.Write("Enter BirthDay: ");
                        partOfProject.BirthDay = int.Parse(Console.ReadLine());
                        Console.Write("Enter LivingPlace: ");
                        partOfProject.LivingPlace = Console.ReadLine();

                        StudentService.UpdatedStudent(partOfProject);

                        break;

                    case 4:

                        Console.Write("Enter ID which you want to get >> ");
                        var idNumber = Guid.Parse(Console.ReadLine());
                        var result = StudentService.GetById(idNumber);

                        string info = $"Student ID: {result.Id}, Student name: {result.Name}, Student surname: {result.Surname}, " +
                            $"Student age: {result.Age}, Student status: {result.Status}, Student birth place: {result.BirthPlace}, Student birthday: {result.BirthDay}, " +
                            $"Student living place: {result.LivingPlace}";

                           Console.WriteLine($"{info}");

                        break;

                    case 5:

                        var resultOfStudents = StudentService.GetBackAllStudents();

                        foreach(var check in resultOfStudents)
                        {
                            string filling = $"Student ID: {check.Id}, Student name: {check.Name}, Student surname: {check.Surname}, " +
                            $"Student age: {check.Age}, Student status: {check.Status}, Student birth place: {check.BirthPlace}, Student birthday: {check.BirthDay}, " +
                            $"Student living place: {check.LivingPlace}";

                            Console.WriteLine($"{filling}");
                        }

                        break;


                }
                Console.ReadKey();
                Console.Clear();



            }
        }











    }
}
