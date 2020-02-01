using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    class Triangle : Shape
    {

        public override List<Point> Vertices
        {
            get
            {
                return base.Vertices;
            }
            set
            {
                if (value.Count == 3)
                {
                    base.Vertices = value;
                }
                else
                {
                    throw new ArgumentException("Triangles must have three points.", "Vertices");
                }
            }
        }

        public Triangle(List<Point> vertices) : base(vertices)
        {
        }

        public Triangle(Point v1, Point v2, Point v3)
        {
            List<Point> Points = new List<Point>
            {
                v1,
                v2,
                v3
            };
            Vertices = Points;
        }

        public override double Perimeter()
        {
            return base.Perimeter();
        }
        public override double Area()
        {
            double s = Perimeter() / 2;
            double a = Vertices[0].Distance(Vertices[1]);
            double b = Vertices[1].Distance(Vertices[2]);
            double c = Vertices[2].Distance(Vertices[0]);
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            return area;
        }

        public virtual bool IsEquilateral()
        {
            double a = Vertices[0].Distance(Vertices[1]);
            double b = Vertices[1].Distance(Vertices[2]);
            double c = Vertices[2].Distance(Vertices[0]);
            
            if (Utils.IsRelativelyEqual(a, b) && Utils.IsRelativelyEqual(b, c) && Utils.IsRelativelyEqual(c, a))
            {
                return true;
            }
            else
            { 
                return false;
            }
        }

        public virtual bool IsIsosceles()
        {
            double a = Vertices[0].Distance(Vertices[1]);
            double b = Vertices[1].Distance(Vertices[2]);
            double c = Vertices[2].Distance(Vertices[0]); 
            
            if (IsEquilateral())
            {
                return true;
            }
            else if (Utils.IsRelativelyEqual(a, b) && Utils.IsRelativelyEqual(b, c))
            {
                return true;
            }
            else if (Utils.IsRelativelyEqual(a, b) && Utils.IsRelativelyEqual(c, a))
            {
                return true;
            }
            else if (Utils.IsRelativelyEqual(b, c) && Utils.IsRelativelyEqual(c, a))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public virtual bool IsScalene()
        {
            if (!IsIsosceles())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return $"Triangle: {base.ToString()}";
        }
    }
}
