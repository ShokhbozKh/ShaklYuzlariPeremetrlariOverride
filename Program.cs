namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Rasmda berilgan struktura asosida klasslarni yarating.
            //area() va perimeter() methodlarini overriding usulida amalga oshiring.
            Figure figure = new Figure();
            figure.Perimeter();
            figure.Area();
            Console.WriteLine();
            Circle circle = new Circle(2.5);
            circle.Perimeter();
            circle.Area();
            Console.WriteLine();
            Rectangle rectangle = new Rectangle(4, 5.4f);
            rectangle.Perimeter();
            rectangle.Area();
            Console.WriteLine();
            Triagle triagle = new Triagle(3, 4, 5);
            triagle.Perimeter();
            triagle.Area();



        }
    }
    class Figure
    {
        public virtual void Area()
        {
            Console.WriteLine("--Umumiy shakillar uchun yuza--");
        }
        public virtual void Perimeter()
        {
            Console.WriteLine("--Umumiy shakllar uchun peremetr--");
        }
    }
    class Circle : Figure
    {
        public double Radius { get; set; }
        public Circle(double r)
        {
            Radius = r;
        }
        public override void Area()
        {
            Console.WriteLine($"Circule Area:{Math.PI*Radius*Radius}");
        }
        public override void Perimeter()
        {
            Console.WriteLine($"Circule Aylana uzunligi:{2*Math.PI*Radius}");
        }
    }
    class Rectangle : Figure
    {
        public float X { get; set; }
        public float Y { get; set; }
        public Rectangle(float X, float Y)
        {
            this.X = X;
            this.Y = Y;   
        }
        public override void Perimeter()
        {
            Console.WriteLine($"Rectangle peremetr:{2*(X+Y)}");
        }
        public override void Area()
        {
            Console.WriteLine($"TurtBurchak Yuzi:{(X * Y)}");

        }

    }
    class Triagle:Figure
    {
        public double sideA { get; set; }
        public double sideB { get; set; }
        public double hipotenuse { get; set; }

        public Triagle(double a, double b, double hipo)
        {
            sideA = a;
            sideB = b;
            hipotenuse = hipo;
        }
        public override void Perimeter()
        {
            Console.WriteLine($"Uchburchak peremetri:{sideA+sideB+hipotenuse}");

        }
        public override void Area()
        {
            Console.WriteLine($"Uchburchak Yuzi:{(sideA*sideB)/2}");

        }

    }
}