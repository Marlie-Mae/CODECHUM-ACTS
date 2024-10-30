using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the recipient: ");
        string recipient = Console.ReadLine();
        
        Console.Write("Enter the message: ");
        string message = Console.ReadLine();
        
        Console.Write("Enter the name: ");
        string senderName = Console.ReadLine();
        
        Console.Write("Enter the subject: ");
        string subject = Console.ReadLine();
        
        Console.Write("Enter the version: ");
        string version = Console.ReadLine();
        
        Console.Write("Enter the discount: ");
        decimal discount = decimal.Parse(Console.ReadLine());
        
        Console.Write("Enter the status: ");
        string status = Console.ReadLine();
        
        Console.Write("Enter the code: ");
        string code = Console.ReadLine();
        
        Console.Write("Enter the location: ");
        string location = Console.ReadLine();
        
        Console.Write("Enter the age: ");
        int age = int.Parse(Console.ReadLine());
        
        Console.Write("Enter the company name: ");
        string companyName = Console.ReadLine();
        
        Console.Write("Enter the website: ");
        string website = Console.ReadLine();
        
        Console.Write("Enter the phone: ");
        string phone = Console.ReadLine();
        
        Console.Write("Enter the job title: ");
        string jobTitle = Console.ReadLine();
        
        Console.Write("Enter the department: ");
        string department = Console.ReadLine();

        Console.WriteLine($"Dear {recipient}, I hope this email finds you well.");
        Console.WriteLine(message);
        Console.WriteLine($"Subject: {subject}");
        Console.WriteLine($"Sender: {senderName}");
        Console.WriteLine($"Version: {version}");
        Console.WriteLine($"Discount: {discount:F2}%");
        Console.WriteLine($"Status: {status}");
        Console.WriteLine($"Code: {code}");
        Console.WriteLine($"Location: {location}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Company: {companyName}");
        Console.WriteLine($"Website: {website}");
        Console.WriteLine($"Phone: {phone}");
        Console.WriteLine($"Job Title: {jobTitle}");
        Console.WriteLine($"Department: {department}");
    }
}
