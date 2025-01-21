using System;
using System.Collections.Generic;

namespace BookManagementApp
{
    public class BookManager
    {
        private List<Book> books = new List<Book>();

        public void AddBook(Book book)
        {
            books.Add(book);
            Console.WriteLine("Книга додана");
        }

        public void RemoveBook(int index)
        {
            if (IsValidIndex(index))
            {
                books.RemoveAt(index);
                Console.WriteLine("Книга видалена");
            }
            else
            {
                Console.WriteLine("Неправильний номер");
            }
        }

        public void DisplayBooks()
        {
            Console.WriteLine("\nСписок книг:");
            if (books.Count == 0)
            {
                Console.WriteLine("Список порожній");
            }
            else
            {
                for (int i = 0; i < books.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {books[i]}");
                }
            }
        }

        public void SearchBooks(string query)
        {
            var results = books.FindAll(book =>
                book.Title.Contains(query, StringComparison.OrdinalIgnoreCase) ||
                book.Author.Contains(query, StringComparison.OrdinalIgnoreCase) ||
                book.Genre.Contains(query, StringComparison.OrdinalIgnoreCase) ||
                book.Year.ToString().Contains(query));

            Console.WriteLine("\nРезультати пошуку:");
            if (results.Count > 0)
            {
                foreach (var book in results)
                {
                    Console.WriteLine(book);
                }
            }
            else
            {
                Console.WriteLine("Нічого не знайдено");
            }
        }

        private bool IsValidIndex(int index)
        {
            return index >= 0 && index < books.Count;
        }
    }
}
