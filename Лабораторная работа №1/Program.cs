using System;

namespace Лабораторная_работа__1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Тюрин Вадим Игревич ИУ5Ц-52Б");
        inA:
            Console.Write("Ведите А:");
            double a = Convert.ToInt32(Console.ReadLine());
            if (a == 0)
            {
                Console.WriteLine("Значение А не должно быть равно 0.");
                goto inA;
            }
            Console.Write("Ведите B:");
            double b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ведите C:");
            double c = Convert.ToInt32(Console.ReadLine());
            double D = b * b - 4 * a * c;
            if (D > 0)
            {
                double y1 = (-b - Math.Sqrt(D)) / (2 * a);
                double y2 = (-b + Math.Sqrt(D)) / (2 * a);
                double x1 = Math.Sqrt(y1);
                double x2 = Math.Sqrt(y2);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"x1 = {x1}");
                Console.WriteLine($"x2 = {x2}");
                Console.WriteLine($"x3 = {-x1}");
                Console.WriteLine($"x4 = {-x2}");
                Console.ResetColor();
            }
            if (D == 0)
            {
                double y1 = -b / (2 * a);
                double x1 = Math.Sqrt(y1);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"x1 = {x1}");
                Console.WriteLine($"x1 = {-x1}");
                Console.ResetColor();
            }
            if (D < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Корней нет");
                Console.ResetColor();

            }
            Console.ReadKey();
        }
    }
}
