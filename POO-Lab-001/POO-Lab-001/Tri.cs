using System;

namespace POO_Lab_001
{
    internal class Tri
    {
        Point x, y, z;

        double a, b, c;

        public Tri(Point x,Point y,Point z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public double Perimetru_Tri()
        {
            a = Math.Sqrt(Math.Pow((x.X - y.X), 2) + Math.Pow((x.Y - y.Y), 2));
            b = Math.Sqrt(Math.Pow((z.X - y.X), 2) + Math.Pow((z.Y - y.Y), 2));
            c = Math.Sqrt(Math.Pow((x.X - z.X), 2) + Math.Pow((x.Y - z.Y), 2));
            return a + b + c;
        }

        public bool Verif_Tri()
        {
            if ((x.X == y.X && y.X == z.X) || (x.Y == y.Y && y.Y == z.Y))
                return false;
            return true;
        }

        public double Aria_Tri()
        {
            double k,sp;
            sp = (a + b + c) / 2;
            k = Math.Sqrt(sp * (sp - a) * (sp - b) * (sp - c));
            return k;
        }

    }
}