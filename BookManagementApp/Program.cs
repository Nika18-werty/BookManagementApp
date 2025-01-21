using System;

namespace BookManagementApp
{
    class Program
    {
        static void Main(string[] args)
        {
            BookManager bookManager = new BookManager();
            while (true)
            {
                Console.WriteLine("\nМеню:");
                Console.WriteLine("1.Додати книгу");
                Console.WriteLine("2.Видалити книгу");
                Console.WriteLine("3.Показати всі книги");
                Console.WriteLine("4.Пошук книги");
                Console.WriteLine("5.Вийти");
                Console.Write("Ваш вибір: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        bookManager.AddBook(CreateBook());
                        break;
                    case "2":
                        Console.Write("Введіть номер книги для видалення: ");
                        int index = int.Parse(Console.ReadLine()) - 1;
                        bookManager.RemoveBook(index);
                        break;
                    case "3":
                        bookManager.DisplayBooks();
                        break;
                    case "4":
                        Console.Write("Введіть текст для пошуку: ");
                        string query = Console.ReadLine();
                        bookManager.SearchBooks(query);
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Неправильний вибір");
                        break;
                }
            }
        }

        static Book CreateBook()
        {
            Console.Write("Назва книги: ");
            string title = Console.ReadLine();

            Console.Write("Автор книги: ");
            string author = Console.ReadLine();

            Console.Write("Жанр книги: ");
            string genre = Console.ReadLine();

            Console.Write("Рік видання: ");
            int year = int.Parse(Console.ReadLine());

            return new Book(title, author, genre, year);
        }
    }
}

