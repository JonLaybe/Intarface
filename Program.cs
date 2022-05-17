using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    interface ITriangle {
        double p { get; }
        double s { get; }
        double S();
        double P();
    }
    abstract class Triangle
    {
        public double[] a { get; set; }
        public double[] b { get; set; }
        public double[] c { get; set; }

        public char Vertex()//Находим вершину
        {
            if (a[0] == b[0] || a[1] == b[1])
                return 'c';
            else if (b[0] == c[0] || b[1] == c[1])
                return 'a';
            else
                return 'b';
        }
    }

    class RovnTriangle : Triangle, ITriangle
    {
        public double p { get; private set; }

        public double s { get; private set; }

        public RovnTriangle(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            a = new double[2] { x1, y1 };
            b = new double[2] { x2, y2 };
            c = new double[2] { x3, y3 };
        }

        public double P()
        {
            p = (Math.Sqrt(Math.Pow(a[0] - b[0], 2) + Math.Pow(a[1] - b[1], 2))) + (Math.Sqrt(Math.Pow(b[0] - c[0], 2) + Math.Pow(b[1] - c[1], 2))) +
                (Math.Sqrt(Math.Pow(a[0] - c[0], 2) + Math.Pow(a[1] - c[1], 2)));
            return p;
        }

        public double S()
        {
            s = 0.5 * Math.Abs((b[0] - a[0]) * (c[1] - a[1]) - (c[0] - a[0]) * (b[1] - a[1]));
            return s;
        }
    }
    class RightTriangle : Triangle, ITriangle
    {
        public double p { get; private set; }

        public double s { get; private set; }

        public RightTriangle(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            a = new double[2] { x1, y1 };
            b = new double[2] { x2, y2 };
            c = new double[2] { x3, y3 };
        }

        public double P()
        {
            p = (Math.Sqrt(Math.Pow(a[0] - b[0], 2) + Math.Pow(a[1] - b[1], 2))) + (Math.Sqrt(Math.Pow(b[0] - c[0], 2) + Math.Pow(b[1] - c[1], 2))) +
                (Math.Sqrt(Math.Pow(a[0] - c[0], 2) + Math.Pow(a[1] - c[1], 2)));
            return p;
        }

        public double S()
        {
            s = 0.5 * Math.Abs((b[0] - a[0]) * (c[1] - a[1]) - (c[0] - a[0]) * (b[1] - a[1]));
            return s;
        }
    }
    class IsoscelesTriangle : Triangle, ITriangle
    {
        public double p { get; private set; }

        public double s { get; private set; }

        public IsoscelesTriangle(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            a = new double[2] { x1, y1 };
            b = new double[2] { x2, y2 };
            c = new double[2] { x3, y3 };
        }

        public double P()
        {
            p = (Math.Sqrt(Math.Pow(a[0] - b[0], 2) + Math.Pow(a[1] - b[1], 2))) + (Math.Sqrt(Math.Pow(b[0] - c[0], 2) + Math.Pow(b[1] - c[1], 2))) +
                (Math.Sqrt(Math.Pow(a[0] - c[0], 2) + Math.Pow(a[1] - c[1], 2)));
            return p;
        }

        public double S()
        {
            s = 0.5 * Math.Abs((b[0] - a[0]) * (c[1] - a[1]) - (c[0] - a[0]) * (b[1] - a[1]));
            return s;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            RovnTriangle rovnTriangle = new RovnTriangle(3, 3, 5, 7, 7, 3);
            Console.WriteLine(rovnTriangle.P());
            Console.WriteLine(rovnTriangle.S());
        }
    }
}
