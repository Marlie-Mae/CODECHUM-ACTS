using System;

class Program
{
    static void Main()
    {
        string recipient = "John";
        string sender = "Jane";
        string subject = "Greetings";
        string version = "1.2";
        double discount = 10.50;
        char status = 'A';
        string code = "ABCD123";
        string location = "City XYZ";
        int age = 30;
        string company = "ABC Corporation";
        string website = "www.example.com";
        string phone = "+1 123-456-7890";
        string jobTitle = "Software Engineer";
        string department = "Engineering";

        Console.WriteLine($"Dear {recipient}, I hope this email finds you well.");
        Console.WriteLine("I wanted to reach out and say hello.");
        Console.WriteLine("I hope you are doing well and enjoying your day.");
        Console.WriteLine("It's been a while since we last spoke, and I wanted to catch up with you.");
        Console.WriteLine("Let's plan to meet up soon and have a great time together!");
        Console.WriteLine($"Subject: {subject}");
        Console.WriteLine($"Sender: {sender}");
        Console.WriteLine($"Version: {version}");
        Console.WriteLine($"Discount: {discount}%");
        Console.WriteLine($"Status: {status}");
        Console.WriteLine($"Code: {code}");
        Console.WriteLine($"Location: {location}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Company: {company}");
        Console.WriteLine($"Website: {website}");
        Console.WriteLine($"Phone: {phone}");
        Console.WriteLine($"Job Title: {jobTitle}");
        Console.WriteLine($"Department: {department}");
    }
}
