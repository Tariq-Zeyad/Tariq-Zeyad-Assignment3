using System;
using System.Drawing;

namespace CSharpBasicsAssignment;

internal class Program
{
    private static void Main()
    {
        Console.WriteLine("=== PART A: Project & Structure ===");

        // .csproj: Contains the project settings and configuration
        // Program.cs: Contains the C# code of our application
        // obj/: Contains temporary and intermediate build files
        // bin/: Contains the build output files of the project

        // This project uses the newer .slnx solution format
        // One advantage of the classic .sln format is its wider compatibility
        // with older tools and Visual Studio versions
        RunTypesDemo();
        RunValueVsReferenceDemo();
    }
    private static void RunTypesDemo()
    {
        Console.WriteLine();
        Console.WriteLine("=== PART B: Types & Casting ===");

        int age = 25;
        long population = 1000000L;
        double height = 175.5;
        decimal price = 99.99m;
        bool isStudent = true;
        char grade = 'A';
        string name = "Ali";
        var city = "Nablus";

        Console.WriteLine($"{age} - {age.GetType()}");
        Console.WriteLine($"{population} - {population.GetType()}");
        Console.WriteLine($"{height} - {height.GetType()}");
        Console.WriteLine($"{price} - {price.GetType()}");
        Console.WriteLine($"{isStudent} - {isStudent.GetType()}");
        Console.WriteLine($"{grade} - {grade.GetType()}");
        Console.WriteLine($"{name} - {name.GetType()}");
        Console.WriteLine($"{city} - {city.GetType()}");
        int number = 50;
        long bigNumber = number; // Implicit casting from int to long
        char letter = 'A';
        int letterValue = letter; // Implicit casting from char to int
        Console.WriteLine("Implicit casting from int to long: ", bigNumber);
        Console.WriteLine("Implicit casting from char to int: ", letterValue);
        double doubleValue = 9.78;
        int intValue = (int)doubleValue; // Explicit casting from double to int
        int anotherIntValue = Convert.ToInt32(doubleValue); // Using Convert class for conversion
        Console.WriteLine("Explicit casting from double to int: ", intValue);
        Console.WriteLine("Using Convert class: ", anotherIntValue);
        int integerDivtions = 5 / 2; // Integer division
        double doubleDivtions = 5.0 / 2.0; // Floating-point division
        Console.WriteLine("Integer division: ", integerDivtions);
        Console.WriteLine("Floating-point division: ", doubleDivtions);
        int originalValue = 300;
        object boxedValue = originalValue; // Boxing
        Console.WriteLine("Boxing: ", boxedValue);
        int unboxedValue = (int)boxedValue; // Unboxing
        Console.WriteLine("Unboxing: ", unboxedValue);
        string validNumberString = "42";
        int parsedNumber = int.Parse(validNumberString);

        Console.WriteLine($"int.Parse(\"{validNumberString}\"): {parsedNumber}");

        string invalidNumberString = "ABC";
        bool tryParseResult = int.TryParse(invalidNumberString, out int result);

        Console.WriteLine($"int.TryParse(\"{invalidNumberString}\") succeeded: {tryParseResult}");

        if (!tryParseResult)
        {
            Console.WriteLine("Parsing failed, the input is not a valid integer");
        }
        /*
       I can't assign a float to a decimal directly,
       so I need to use a cast first.

       // float floatValue = 10.5f;
       // decimal decimalValue = floatValue;
       */
        float floatValue = 10.5f;
        decimal decimalValue = (decimal)floatValue;
        Console.WriteLine($"float -> decimal using explicit cast: {decimalValue}");
    }
    struct Point
    {
        public int X;
        public int Y;
    }

    private static void RunValueVsReferenceDemo()
    {
        Point p1 = new Point { X = 1, Y = 2 };
        Point p2 = p1;
        p2.X = 99;
        // Since Point is a struct, p2 gets its own copy of p1
        Console.WriteLine($"p1.X = {p1.X}");
        Console.WriteLine("========================================================================");
        Console.WriteLine($"p2.X = {p2.X}");
        Order order= new Order();
        order.OrderId = 1;
        order.CustomerName = "Ali";
        order.Quantity = 5;
        order.UnitPrice = 10.5m;
        order.DiscountPercent = 10;
        order.ShippingCity = "Nablus";
        order.Priority = 'H';
        order.IsPaid = true;
        order.ItemCode = 1234567890;
        order.TotalPrice = order.CalculateTotal();
        order.PrintSummary();
        Order order2 = order;
        order2.IsPaid = true;
        Console.WriteLine("========================================================================");
        Console.WriteLine($"order.IsPaid = {order.IsPaid}");
        Console.WriteLine($"order2.IsPaid = {order2.IsPaid}");
        Console.WriteLine("========================================================================");
        object boxedOrder = order;
        Order order3 = (Order)boxedOrder;

        Console.WriteLine(object.ReferenceEquals(order, order3));
    }



}

