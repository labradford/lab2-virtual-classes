using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    class Rectangle : Shape

    {

        public double Width
        {
            get
            {
                var bounds = Utils.GetBoundingBox(Vertices);
                return Math.Abs(bounds.Item3 - bounds.Item1);
            }

        }

        public double Height
        {
            get
            {
                var bounds = Utils.GetBoundingBox(Vertices);
                return Math.Abs(bounds.Item2 - bounds.Item4);
            }

        }
        
        public override List<Point> Vertices
        {
            get
            {
                return base.Vertices;
            }
            set
            {
                if (value.Count == 4 || value.Count == 2)
                {
                    base.Vertices = Normalize(value);
                }
                else
                {
                    throw new ArgumentException("Rectangles must have four points.", "Vertices");
                }
            }
        }

        public Rectangle(List<Point> vertices) : base(vertices)
        {
        }

        public Rectangle(Point v1, Point v2)
        {
            List<Point> Points = new List<Point>
            {
                v1,
                new Point(v2.X, v1.Y),
                v2,
                new Point(v1.X, v2.Y)
            };
            Vertices = Points; 

        }

        public Rectangle(Point v1, Point v2, Point v3, Point v4)
        {
            Vertices = new List<Point>() { v1, v2, v3, v4 };
        }

        private List<Point> Normalize(List<Point> input)
        {
            List <Point> Points = new List<Point>();
            if (input != null && input.Count == 4)
            {
                var bounds = Utils.GetBoundingBox(input);
                Points.Add(new Point(bounds.Item1, bounds.Item2));
                Points.Add(new Point(bounds.Item1, bounds.Item4));
                Points.Add(new Point(bounds.Item3, bounds.Item4));
                Points.Add(new Point(bounds.Item3, bounds.Item2));
                return Points;
            }
            else if (input != null && input.Count == 2)
            {
                Points.Add(input[0]);
                Points.Add(new Point(input[1].X, input[0].Y));
                Points.Add(input[1]);
                Points.Add(new Point(input[0].X, input[1].Y));
                return Points;
            }
            else
            {
                throw new ArgumentException("you must supply either two or four points", "input");
            }
        }

        public bool IsSquare()
        {
            if (Width == Height)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Triangle> ToTriangles()
        {
            List<Triangle> triangles = new List<Triangle>();
            triangles.Add(new Triangle(Vertices[0], Vertices[1], Vertices[2]));
            triangles.Add(new Triangle(Vertices[2], Vertices[3], Vertices[0]));
            return triangles;
        }

        public override double Area()
        {
            return Width * Height;
        }

        public override double Perimeter()
        {
            return base.Perimeter();
        }

        public override string ToString()
        {
            return $"Rectangle: {base.ToString()}";
        }


    }
}
