using System;

class Program
{
    public static void Main()
    {
        Console.WriteLine("===== MENU =====");
        Console.WriteLine("1. Operate two numbers");
        Console.WriteLine("2. Display certain values of the function");
        Console.WriteLine("3. Display speed in km/h");
        Console.WriteLine("4. Calculates and displays the surface and volume of the sphere");
        Console.WriteLine("5. Character classification");
        Console.WriteLine("6. Check even or odd number");
        Console.WriteLine("7. Find the largest of three numbers");
        Console.WriteLine("8. accept a coordinate point (x, y) and determine the quadrant in which the point lies");
        Console.Write("Select an option (1-8): ");
        int Choice = int.Parse(Console.ReadLine());
        switch (Choice)
        {
            case 1: ArithmeticCalculator(); break;
            case 2: QuadraticEvaluator(); break;
            case 3: SpeedCalculator(); break;
            case 4: SphereAndVolumeCalculator(); break;
            case 5: CharacterClassifier(); break;
            case 6: CheckEvenOrOdd(); break;
            case 7: FindLargestOfThreeNumbers(); break;
            case 8: DetermineQuadrant(); break;
        }
    }
    static void ArithmeticCalculator()
    {
        Console.Write("Enter first number: ");
        double num1 = double.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        double num2 = double.Parse(Console.ReadLine());
        Console.WriteLine($"Addition: {num1 + num2}");
        Console.WriteLine($"Subtraction: {num1 - num2}");
        Console.WriteLine($"Multiplication: {num1 * num2}");
        if (num2 != 0)
            Console.WriteLine($"Division: {num1 / num2}");
        else
            Console.WriteLine("Division by zero is not allowed.");
    }
    static void QuadraticEvaluator()
    {
        Console.WriteLine("x=y*y+2*y+1");
        for (int y = -5; y <= 5; y++)
        {
            int x = y * y + 2 * y + 1;
            Console.WriteLine($"y={y}, x={x}");
        }
    }
    static void SpeedCalculator()
    {
        Console.Write("Enter distance in meters: ");
        double distance = double.Parse(Console.ReadLine());
        Console.Write("Enter time in hour: ");
        double hour = double.Parse(Console.ReadLine());
        Console.Write("Enter time in minutes: ");
        double minutes = double.Parse(Console.ReadLine());
        Console.Write("Enter time in seconds: ");
        double seconds = double.Parse(Console.ReadLine());
        double time = hour * 3600 + minutes * 60 + seconds; // Convert total time to seconds
        if (time > 0)
        {
            double speed = (distance / time) * 3.6; // Convert m/s to km/h
            Console.WriteLine($"Speed: {speed} km/h");
            double speedInMiles = speed / 1.609; // Convert km/h to miles/h
            Console.WriteLine($"Speed: {speedInMiles} miles/h");
        }
        else
        {
            Console.WriteLine("Time must be greater than zero.");
        }
    }
    static void SphereAndVolumeCalculator()
    {
        Console.Write("Enter radius of the sphere: ");
        double radius = double.Parse(Console.ReadLine());
        if (radius >= 0)
        {
            double surfaceArea = 4 * Math.PI * radius * radius;
            double volume = (4.0 / 3.0) * Math.PI * radius * radius * radius;
            Console.WriteLine($"Surface Area: {surfaceArea}");
            Console.WriteLine($"Volume: {volume}");
        }
        else
        {
            Console.WriteLine("Radius must be non-negative.");
        }
    }
    static void CharacterClassifier()
    {
        Console.Write("Enter a character: ");
        char ch = Console.ReadLine()[0];
        if ((ch == 'a') || (ch == 'e') || (ch == 'i') || (ch == 'o') || (ch == 'u') ||
            (ch == 'A') || (ch == 'E') || (ch == 'I') || (ch == 'O') || (ch == 'U'))
        {
            Console.WriteLine($"{ch} is a vowel.");
        }
        else if ((ch >= '0' && ch <= '9'))
        {
            Console.WriteLine($"{ch} is a digit.");
        }
        else
        {
            Console.WriteLine($"{ch} is an other symbol.");
        }
    }
    static void CheckEvenOrOdd()
    {
        Console.Write("Enter an integer: ");
        int number = int.Parse(Console.ReadLine());
        if (number % 2 == 0)
        {
            Console.WriteLine($"{number} is even.");
        }
        else
        {
            Console.WriteLine($"{number} is odd.");
        }
    }
    static void FindLargestOfThreeNumbers()
    {
        Console.Write("Enter first number: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        int num2 = int.Parse(Console.ReadLine());
        Console.Write("Enter third number: ");
        int num3 = int.Parse(Console.ReadLine());
        int largest = num1;
        if (num2 > largest)
            largest = num2;
        if (num3 > largest)
            largest = num3;
        Console.WriteLine($"The largest number is: {largest}");
    }
    static void DetermineQuadrant()
    {
        Console.Write("Enter x coordinate: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Enter y coordinate: ");
        double y = double.Parse(Console.ReadLine());
        if (x > 0 && y > 0)
            Console.WriteLine("The point is in the First quadrant.");
        else if (x < 0 && y > 0)
            Console.WriteLine("The point is in the Second quadrant.");
        else if (x < 0 && y < 0)
            Console.WriteLine("The point is in the Third quadrant.");
        else if (x > 0 && y < 0)
            Console.WriteLine("The point is in the Fourth quadrant.");
        else if (x == 0 && y != 0)
            Console.WriteLine("The point is on the Y axis.");
        else if (y == 0 && x != 0)
            Console.WriteLine("The point is on the X axis.");
        else
            Console.WriteLine("The point is at the Origin.");
    }
}