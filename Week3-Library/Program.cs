class Book
{
    string Title;
    string Author;
    string ISBN;

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

        // Output the first books information to the console
        Console.WriteLine($"Book title: {book.Title}");
        Console.WriteLine($"Book author: {book.Author}");
        Console.WriteLine($"Book ISBN: {book.ISBN}");

        // Output the second books information to the console
        Console.WriteLine($"Book title: {book1.Title}");
        Console.WriteLine($"Book author: {book1.Author}");  
        Console.WriteLine($"Book ISBN: {book1.ISBN}");
    }
}