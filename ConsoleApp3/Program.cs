using System;

namespace SquareEquation
{
    public class liczenie
    {
        public static void solveSquareEquation(double a, double b, double c, out double x1, out double x2)
        {
            
            double delta = b * b - 4 * a * c;

            if (delta >= 0)
            {
                x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                x2 = (-b + Math.Sqrt(delta)) / (2 * a);
            }
            else
            {
                x1 = double.NaN;
                x2 = double.NaN;
            }
            
            
        }

        

        static void Main(string[] args)
        {
            try
            {
                Console.Write("Podaj a = ");
                double a = double.Parse(Console.ReadLine());

                Console.Write("Podaj b = ");
                double b = double.Parse(Console.ReadLine());

                Console.Write("Podaj c = ");
                double c = double.Parse(Console.ReadLine());

                Console.WriteLine("Równanie: " + a + "x^2 + " + b + "x + " + c + " = 0");

                double x1, x2;
                solveSquareEquation(a, b, c, out x1, out x2);
                Console.WriteLine("Rozwiązania x1 = " + x1 + ", x2 = " + x2);
            }
            catch (Exception exc)
            {
                Console.Error.WriteLine(exc.Message);
            }
        }
    }
}
