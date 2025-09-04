using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("===== MENU =====");
        Console.WriteLine("1. Operate two numbers");
        Console.WriteLine("2. Display certain values of the function");
        Console.WriteLine("3. Display speed in km/h and miles/h");
        Console.WriteLine("4. Calculates and displays the surface and volume of the sphere");
        Console.WriteLine("5. Character classification");
        Console.WriteLine("6. Check even or odd number");
        Console.WriteLine("7. Find the largest of three numbers");
        Console.WriteLine("8. Accept a coordinate point (x, y) and determine the quadrant in which the point lies");
        Console.WriteLine("9. Check Triangle Type");
        Console.WriteLine("10. Read 10 numbers and calculate sum and average");
        Console.WriteLine("11. Display the multiplication table");
        Console.WriteLine("12. Display a pattern like triangles");
        Console.WriteLine("13. Harmonic series");
        Console.WriteLine("14. Perfect number in range");
        Console.WriteLine("15. Check Prime number");
        Console.WriteLine("Select an option (1-15): ");
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
            case 9: CheckTriangle(); break;
            case 10: SumAndAverage10Numbers(); break;
            case 11: MultiplicationTable(); break;
            case 12: NumberPatterns(); break;
            case 13: HarmonicSeries(); break;
            case 14: PerfectNumberInRange(); break;
            case 15: PrimeNumberCheck(); break;
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
    static void CheckTriangle()
    {
        Console.Write("Enter first side length: ");
        double side1 = double.Parse(Console.ReadLine());
        Console.Write("Enter second side length: ");
        double side2 = double.Parse(Console.ReadLine());
        Console.Write("Enter third side length: ");
        double side3 = double.Parse(Console.ReadLine());
        if (side1 <= 0 || side2 <= 0 || side3 <= 0)
        {
            Console.WriteLine("Side lengths must be positive.");
            return;
        }
        if (side1 + side2 > side3 && side1 + side3 > side2 && side2 + side3 > side1)
        {
            Console.WriteLine("The lengths can form a triangle.");
            if (side1 == side2 && side2 == side3)
                Console.WriteLine("The triangle is Equilateral.");
            else if (side1 == side2 || side1 == side3 || side2 == side3)
                Console.WriteLine("The triangle is Isosceles.");
            else
                Console.WriteLine("The triangle is Scalene.");
        }
        else
        {
            Console.WriteLine("The lengths cannot form a triangle.");
        }
    }
    static void SumAndAverage10Numbers()
    {
        int sum = 0;
        Console.WriteLine("Enter 10 numbers:");
        for (int i = 1; i <= 10; i++)
        {
            Console.Write($"Number {i}: ");
            int num = int.Parse(Console.ReadLine());
            sum += num;
        }
        double average = sum / 10.0;
        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Average: {average}");
    }
    static void MultiplicationTable()
    {
        Console.Write("Enter an integer: ");
        int num = int.Parse(Console.ReadLine());
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{num} x {i} = {num * i}");
        }
    }
    static void NumberPatterns()
    {
        Console.Write("Enter number of rows: ");
        int rows = int.Parse(Console.ReadLine());
        Console.WriteLine("\nPattern 1:");
        for (int i = 1; i <= rows; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine("\nPattern 2:");
        for (int i = rows; i >= 1; i--)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine("\nPattern 3:");
        for (int i = 1; i <= rows; i++)
        {
            for (int j = 1; j <= rows - i; j++)
            {
                Console.Write("  ");
            }
            for (int k = 1; k <= i; k++)
            {
                Console.Write(k + " ");
            }
            Console.WriteLine();
        }
    }
    static void HarmonicSeries()
    {
        Console.Write("Enter a positive integer: ");
        int n = int.Parse(Console.ReadLine());
        if (n <= 0)
        {
            Console.WriteLine("Please enter a positive integer.");
            return;
        }
        double harmonicSum = 0.0;
        for (int i = 1; i <= n; i++)
        {
            harmonicSum += 1.0 / i;
        }
        Console.WriteLine($"The {n}th Harmonic number is: {harmonicSum}");
    }
    static void PerfectNumberInRange()
    {
        Console.Write("Enter the upper limit: ");
        int limit = int.Parse(Console.ReadLine());
        Console.WriteLine($"Perfect numbers up to {limit} are:");
        for (int num = 1; num <= limit; num++)
        {
            int sumOfDivisors = 0;
            for (int i = 1; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    sumOfDivisors += i;
                }
            }
            if (sumOfDivisors == num)
            {
                Console.WriteLine(num + "is a Perfect Number");
            }
        }
    }
    static void PrimeNumberCheck()
    {
        Console.Write("Enter a positive integer: ");
        int number = int.Parse(Console.ReadLine());
        if (number <= 1)
        {
            Console.WriteLine("Please enter a positive integer greater than 1.");
            return;
        }
        bool isPrime = true;
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                isPrime = false;
                break;
            }
        }
        if (isPrime)
        {
            Console.WriteLine($"{number} is a prime number.");
        }
        else
        {
            Console.WriteLine($"{number} is not a prime number.");
        }
    }
}






