using System;

internal class Program
{
    private static int delta;

    private static void Main()
    {
        //coefficients of a quadratic equation:
        double a, b, c, delta = 0;
        try
        {
            Console.WriteLine("Insert a value:");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Insert b value:");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Insert c value:");
            c = double.Parse(Console.ReadLine());
            delta = Math.Pow(b, 2) - (4 * a * c);//delta needed for the next calculations
            Console.WriteLine(" ");
            Console.WriteLine("Delta = {0:F2}", delta );
        }
        catch (FormatException)
        {
            Console.WriteLine("Incorrect data insered. Try again");
            return;
        }
        if (delta > 0) // when delta > 0, the quadratic equation has two real roots
        {
            double x1 = (-b + Math.Sqrt(delta))/ (2 * a);
            double x2 = (-b - Math.Sqrt(delta))/ (2 * a);
            Console.WriteLine("Delta > 0 , so quadratic equation has two real roots: x1= {0:F2} and x2= {1:F2}", x1 , x2);
        }
        else if (delta == 0) // when delta = 0, the quadratic equation has one real root
        {
            double x = (-b) / (2 * a);
            Console.WriteLine("Delta = 0, so quadratic equation has one real root: x= {0:F2}", x);
        }
        else if (delta < 0)// delta < 0, the quadratic equation has no real root
        {
            Console.WriteLine("Delta < 0, so quadratic equation has no real roots.");
        }
        Console.ReadKey();
    }
}