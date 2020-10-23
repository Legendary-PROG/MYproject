using System;

namespace Laba_2
{
    class Program
    {


        interface IPrint
        {
            void Print();
        }

        abstract class Shape
        {
            public virtual double Area() { return 0.0; }
        }

        class Rectangle : Shape, IPrint
        {
            public double Width { get; set; }
            public double Height { get; set; }

            public Rectangle(double w, double h)
            {
                Width = w;
                Height = h;
            }

            public override double Area()
            {
                return Width * Height;
            }

            public override string ToString()
            {
                return Width + " " + Height + " " + Area();
            }

            public void Print()
            {
                Console.WriteLine(ToString());
            }
        }

        class Squeare : Rectangle, IPrint
        {
            public Squeare(double len) : base(len, len) { }

            public override string ToString()
            {
                return base.Width + " " + base.Area();
            }


        }

        class Circle : Shape, IPrint
        {
            public double Radius { get; set; }

            public Circle(double r)
            {
                Radius = r;
            }

            public override double Area()
            {
                return Math.PI * Radius * Radius;
            }

            public override string ToString()
            {
                return Radius + " " + Area();
            }

            public void Print()
            {
                Console.WriteLine(ToString());
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Тюрин Вадим Игревич ИУ5Ц-52Б");

            //Rectangle obj = new Rectangle(10, 5);
            //Console.WriteLine(obj);
            //obj.Print();

            //Squeare obj = new Squeare(5);
            //Console.WriteLine(obj);
            //obj.Print();


            Circle obj = new Circle(3);
            Console.WriteLine(obj);
            obj.Print();
            Console.ReadKey();

        }
    }
}
