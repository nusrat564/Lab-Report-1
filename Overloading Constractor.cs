using System;

class Book
{
    public string Title;
    public string AuthorName;
    public double ISBN;
    public double Price;

    public Book()
    {
        Title = "Unknown";
        AuthorName = "Unknown";
        ISBN = 0;
        Price = 0;
    }

    public Book(string _title, string _author)
    {
        Title = _title;
        AuthorName = _author;
    }

    public Book(string _title, string _author, double _isbn)
    {
        Title = _title;
        AuthorName = _author;
        ISBN = _isbn;
    }

    public Book(string _title, string _author, double _isbn, double _price)
    {
        Title = _title;
        AuthorName = _author;
        ISBN = _isbn;
        Price = _price;
    }

    public void Print()
    {
        Console.WriteLine("Title: " + Title);
        Console.WriteLine("Name: " + AuthorName);
        Console.WriteLine("ISBN: " + ISBN);
        Console.WriteLine("Price: " + Price);
    }

    static void Main()
    {
        Book b1 = new Book();
        Book b2 = new Book("Game Of Thrones", "George R.R. Martin");
        Book b3 = new Book("Game Of Thrones", "George R.R. Martin", 2006);
        Book b4 = new Book("Game Of Thrones", "George R.R. Martin", 2006, 2000);

        b1.Print();
        b2.Print();
        b3.Print();
        b4.Print();
    }
}
