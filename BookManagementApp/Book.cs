namespace BookManagementApp
{
    public class Book
    {
        public string Title;
        public string Author;
        public string Genre;
        public int Year;

        public Book(string title, string author, string genre, int year)
        {
            Title = title;
            Author = author;
            Genre = genre;
            Year = year;
        }

        public override string ToString()
        {
            return $"Назва: {Title}, Автор: {Author}, Жанр: {Genre}, Рік: {Year}";
        }
    }
}
