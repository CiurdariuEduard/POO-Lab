using System;

namespace POO_Lab_001
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(0, 0);
            Point p2 = new Point(3, 0);
            Point p3 = new Point(0, 4);
            Console.WriteLine(p1.X + " " + p1.Y);
            p1.Rotate(10);
            Console.WriteLine(p1.X + " " + p1.Y);
            p1.Rotate(-10);
            Console.WriteLine(p1.X + " " + p1.Y);
            Console.WriteLine();
            Tri t = new Tri(p1, p2, p3);
            Console.WriteLine("p = " + t.Perimetru_Tri());
            if (t.Verif_Tri())
                Console.WriteLine("Este triunghi.");
            else
                Console.WriteLine("Nu este triunghi.");
            Console.WriteLine("a = " + t.Aria_Tri());
            Console.Read();
        }
    }
}
