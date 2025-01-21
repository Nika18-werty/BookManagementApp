namespace BookManagementApp
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }

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
