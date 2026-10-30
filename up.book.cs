public class Book1
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Pages { get; set; }
    public int Year { get; set; }
    public Book1(){}

    public Book1(string title, string author, int pages, int year)
    {
        Title = title;
        Author = author;
        Pages = pages;
        Year = year;
    }
}