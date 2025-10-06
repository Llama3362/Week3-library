class Book
{
    string Title;
    string Author;
    string ISBN;

    void DisplayInfo()
    {
        Console.WriteLine($"Book title: {Title}");
        Console.WriteLine($"Book author: {Author}");
        Console.WriteLine($"Book ISBN: {ISBN}");
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        //Create a new instance of Book class
        Book book = new Book();

        //First new instance of book class
        book.Title = "C# for beginners";
        book.Author = "BillGates";
        book.ISBN = "12345678";

        //Second new instance of Book class
        Book book1 = new Book();
        book1.Title = "C# Methods and Classes";
        book1.Author = "Microsoft";
        book1.ISBN = "55667778";

        // Output book information to the console
        book.DisplayInfo();
        book1.DisplayInfo();
    }
}