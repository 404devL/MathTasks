using System;

namespace MathTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, y1, x2, y2, x3, y3;
            double a, b, c, square, perimeter, p;

            //Новый коммент
            Console.WriteLine("Math operations.\n");
            Console.WriteLine("Введите координаты вершин треугольника");
            Console.Write("X1 = ");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Y1 = ");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("X2 = ");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Y2 = ");
            y2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("X3 = ");
            x3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Y3 = ");
            y3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Branch fix");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            a = MathOperationFoundA(x1, y1, x2, y2);
            b = MathOperationFoundB(x2, y2, x3, y3);
            c = MathOperationFoundC(x1, y1, x3, y3);

            perimeter = FoundPerimetr(a, b, c);
            p = Foundp(a, b, c);
            square = FoundSquare(a, b, c, p);
            Console.WriteLine($"Периметр треугольника = {perimeter}");
            Console.WriteLine($"Площадь треугольника = {square}");

            Console.ReadLine();
        }

        private static double FoundSquare(double a, double b, double c, double p)
        {
            double square = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return square;
        }

        private static double Foundp(double a, double b, double c)
        {
            double p = Math.Abs(a + b + c) / 2;
            return p;
        }

        private static double FoundPerimetr(double a, double b, double c)
        {
            double perimeter = Math.Sqrt(Math.Pow(b, 2) + Math.Pow(c, 2) - 2 * b * c * Math.Acos(a) + (b + c));
            return perimeter;
        }

        private static double MathOperationFoundA(double x1, double y1, double x2, double y2)
        {
            double a = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return a;
        }

        private static double MathOperationFoundB(double x2, double y2, double x3, double y3)
        {
            double b = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
            return b;
        }

        private static double MathOperationFoundC(double x1, double y1, double x3, double y3)
        {
            double c = Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2));
            return c;
        }
    }
}


