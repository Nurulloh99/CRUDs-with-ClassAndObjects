using Third_CRUD_of_8th_lesson.Models;
using Third_CRUD_of_8th_lesson.Services;

namespace Third_CRUD_of_8th_lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RunFrontEnd();
        }

        public static void RunFrontEnd()
        {
            var bookSevices = new BooksServices();

            while (true)
            {
                Console.WriteLine("1. Adding new book");
                Console.WriteLine("2. Removing a book");
                Console.WriteLine("3. Updating old book");
                Console.WriteLine("4. Getting all books");
                Console.WriteLine("5. Getting one book by ID\n");
                Console.Write("Enter your option which you want >> ");
                var option = int.Parse(Console.ReadLine());

                var books = new Books();

                switch (option)
                {
                    case 1:

                        Console.Write("Enter Name: ");
                        books.Name = Console.ReadLine();
                        Console.Write("Enter Author: ");
                        books.Author = Console.ReadLine();
                        Console.Write("Enter Description: ");
                        books.Description = Console.ReadLine();
                        Console.Write("Enter DateTime: ");
                        books.DateTimee = int.Parse(Console.ReadLine());
                        Console.Write("Enter Where: ");
                        books.Where = Console.ReadLine();
                        Console.Write("Enter Pages: ");
                        books.Pages = int.Parse(Console.ReadLine());

                        bookSevices.AddedBook(books);

                        break;

                    case 2:

                        Console.Write("Enter ID of the book >> ");
                        var optionOfID = Guid.Parse(Console.ReadLine());
                        var result = bookSevices.DeletedBook(optionOfID);
                        Console.WriteLine(result);

                        break;

                    case 3:

                        Console.Write("Enter ID of the book >> ");
                        books.Id = Guid.Parse(Console.ReadLine());
                        Console.Write("Enter Name: ");
                        books.Name = Console.ReadLine();
                        Console.Write("Enter Author: ");
                        books.Author = Console.ReadLine();
                        Console.Write("Enter Description: ");
                        books.Description = Console.ReadLine();
                        Console.Write("Enter DateTime: ");
                        books.DateTimee = int.Parse(Console.ReadLine());
                        Console.Write("Enter Where: ");
                        books.Where = Console.ReadLine();
                        Console.Write("Enter Pages: ");
                        books.Pages = int.Parse(Console.ReadLine());

                        var updatingBook = bookSevices.UpdatedBook(books);

                        break;

                    case 4:

                        var getAllBooks = bookSevices.GetBackAllBooks();

                        foreach(var check in getAllBooks)
                        {
                            string info = $"Book's ID: {check.Id}, Name: {check.Name}, Author: {check.Author}, Description: {check.Description}, DateTime: {check.DateTimee}, Where: {check.Where}, Pages: {check.Pages}";
                            Console.WriteLine($"{info}");
                        }

                        break;

                    case 5:

                        Console.Write("Enter ID to get in console >> ");
                        var booksIDforCheck = Guid.Parse(Console.ReadLine());
                        var results = bookSevices.GetByID(booksIDforCheck);

                            string informations = $"Book's ID: {results.Id}, Author: {results.Author}, Description: {results.Description}, DateTime: {results.DateTimee}, Where: {results.Where}, Pages: {results.Pages}";
                            Console.WriteLine($"{informations}");
                        
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
