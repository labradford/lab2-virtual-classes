﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    public struct Point
    {
        public double X;
        public double Y;

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double Distance(Point other)
        {
            return Math.Sqrt(Math.Pow(other.X - X, 2) + Math.Pow(other.Y - Y, 2));
        }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }
}
