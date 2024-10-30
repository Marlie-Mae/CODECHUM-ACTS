using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the book title: ");
        string title = Console.ReadLine();
        
        Console.Write("Enter the author: ");
        string author = Console.ReadLine();
        
        Console.Write("Enter the year of publication: ");
        int yearOfPublication = int.Parse(Console.ReadLine());
        
        Console.Write("Enter the genre: ");
        string genre = Console.ReadLine();
        
        Console.Write("Enter the library: ");
        string library = Console.ReadLine();
        
        Console.Write("Enter your member ID: ");
        string memberId = Console.ReadLine();
        
        Console.Write("Enter the return date: ");
        string returnDate = Console.ReadLine();

        Console.WriteLine($"You have successfully reserved the book '{title}' by {author}.");
        Console.WriteLine($"Year of Publication: {yearOfPublication}");
        Console.WriteLine($"Genre: {genre}");
        Console.WriteLine($"Library: {library}");
        Console.WriteLine($"Member ID: {memberId}");
        Console.WriteLine($"Return Date: {returnDate}");
    }
}
