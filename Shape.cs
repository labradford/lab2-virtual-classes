using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    public abstract class Shape
    {
        protected List<Point> _Vertices = new List<Point>();

        public virtual List<Point> Vertices {
            get
            {
                return _Vertices;
            } 
            set
            {
                _Vertices = value;
            }
        }

        public Shape()
        {
        }

        public Shape(List<Point> vertices)
        {
            Vertices = vertices;
        }

        public abstract double Area();

        public virtual double Perimeter()
        {
            double perimeter = 0;
            for (int i = 0; i < Vertices.Count; ++i)
            {
                if (i == Vertices.Count - 1)
                {
                    perimeter += Vertices[i].Distance(Vertices[0]);
                }
                else
                {
                    perimeter += Vertices[i].Distance(Vertices[i + 1]);
                }
            }
            return perimeter;
        }

        public override string ToString()
        {
            string s = String.Empty;

            for (int i = 0; i < Vertices.Count; ++i)
            {
                if (i == 0)
                {
                    s += $"{Vertices[i]}";
                }
                else
                {
                    s += $", {Vertices[i]}";
                }
            }
            
            return s;
        }
    }
}
