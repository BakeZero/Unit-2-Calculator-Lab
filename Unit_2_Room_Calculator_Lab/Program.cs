using System;
using System.Formats.Asn1;

public class Program
{
    static void Main()
    {
        decimal length = 0;
        decimal width = 0;
        decimal height = 0;

        Console.WriteLine("Welcome to Grand Circus' Room Detail Generator!");
        Console.Write("Enter length: ");
        length = decimal.Parse(Console.ReadLine());
        Console.Write("Enter width: ");
        width = decimal.Parse(Console.ReadLine());
        Console.Write("Enter height: ");
        height = decimal.Parse(Console.ReadLine());

        decimal area = length * width;
        decimal perimeter = 2 * (length + width);
        decimal volume = length * width * height;
        decimal surfaceArea = 2*(length * width + width * height + length * height);

        Console.WriteLine($"Area: {area}");
        Console.WriteLine($"Perimeter: {perimeter}");
        Console.WriteLine($"Volume: {volume}");
        Console.WriteLine($"Surface area: {surfaceArea}");

        string roomSize = "";
        if (area <= 250)
            roomSize = "small";
        else if (area > 250 && area < 650)
            roomSize = "medium";
        else if (area >= 650)
            roomSize = "large";

        Console.WriteLine($"Calculated: This is a {roomSize}-sized room.");
        Console.WriteLine("Thank you for using the Room Detail Generator!");
    }
}