using System;

namespace POO_Lab_001
{
    internal class Point
    {
        double abscisa, ordonata;

        public Point(double x, double y)
        {
            this.abscisa = x;
            this.ordonata = y;
        }

        public double X
        {
            get
            {
                return abscisa;
            }
        }

        public double Y
        {
            get
            {
                return ordonata;
            }
        }

        public void Rotate(double t)
        {
            double x1, y1;
            t = t * Math.PI / 180;
            
            x1 = abscisa * Math.Cos(t) - ordonata * Math.Sin(t);
            y1 = ordonata * Math.Cos(t) + abscisa * Math.Sin(t);
            abscisa = x1;
            ordonata = y1;
        }

    }
}