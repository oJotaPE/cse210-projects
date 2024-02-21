using System;
using System.Collections.Generic; 
class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Address address1 = new Address();
        Address address2 = new Address();
        Address address3 = new Address();

        Console.WriteLine("Welcome to the Event planning program");
        // Address address1 = new Address();
        Lecture lecture = new Lecture("Innovation and technoogy: the future of Business", "Digital Transformation: Learn about the importance of digital transformation for businesses, strategies for implementation, and real - world case studies of successful transformations.", "05/23", "6 pm", address1.GetAddressLine(), "Lina Sully", 3000);
        Console.WriteLine("Lecture Event:");
        Console.WriteLine("\n1. Standard Details:");
        Console.WriteLine(lecture.GenerateStandard());

        Console.WriteLine("\n2. Full Details:");
        Console.WriteLine(lecture.GenerateFull());

        Console.WriteLine("\n3. Short Details:");
        Console.WriteLine(lecture.GenerateShort());

        Console.WriteLine("------------------------ ** ------------------------");

        Outdoor outdoor = new Outdoor("Sunset Yoga by the Lake","Unwind and recharge with our 'Sunset Yoga by the Lake' event. Immerse yourself in the peaceful ambiance of nature as you flow through a guided yoga session against the backdrop of a breathtaking sunset. Connect with your inner self, breathe in the fresh air, and find serenity in the beauty of the outdoors. This event is suitable for all levels, promoting wellness and relaxation in a tranquil lakeside setting.","03/05","9 am", address2.GetAddressLine());
        Console.WriteLine("Outdoor Gathering:");
        Console.WriteLine("\n1. Standard Details:");
        Console.WriteLine(outdoor.GenerateStandard());

        Console.WriteLine("\n2. Full Details:");
        Console.WriteLine(outdoor.GenerateFull());

        Console.WriteLine("\n3. Short Details:");
        Console.WriteLine(outdoor.GenerateShort());

        Console.WriteLine("------------------------ ** ------------------------");

        Reception reception = new Reception("Sabrina and Tomas's Wedding", "is a beautiful celebration of love, uniting two souls in matrimony. Join us for an enchanting ceremony, followed by a joyous reception filled with delightful moments and heartfelt celebrations.", "07/16", "4 pm", address3.GetAddressLine(), 250);
        Console.WriteLine("Reception Event:");
        Console.WriteLine("\n1. Standard Details:");
        Console.WriteLine(reception.GenerateStandard());

        Console.WriteLine("\n2. Full Details:");
        Console.WriteLine(reception.GenerateFull());

        Console.WriteLine("\n3. Short Details:");
        Console.WriteLine(reception.GenerateShort());
    }
}