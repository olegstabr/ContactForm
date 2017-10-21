namespace ContactForm.Entity
{
    public sealed class BookEntity
    {
        public int ID;
        public string Name; 
        public string Author;
        public int Year;
        public string PublishHouse;

        public BookEntity() { }

        public BookEntity(string name, string author, int year, string publishHouse)
        {
            Name = name;
            Author = author;
            Year = year;
            PublishHouse = publishHouse;
        }
    }
}