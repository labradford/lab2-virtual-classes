using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    static class Utils
    {
        public static bool IsRelativelyEqual(double d1, double d2)
        {
            double margin = Math.Abs((((d1 + d2) / 2) * 0.0001));
            double difference = Math.Abs(d1 - d2);

            if (difference < margin)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static Tuple<double, double, double, double> GetBoundingBox(List<Point> points)
        {
            double minX = 0;
            double minY = 0;
            double maxX = 0;
            double maxY = 0;
            foreach (Point p in points)
            {
                if (p.X < minX)
                {
                    minX = p.X;
                }
                if (p.Y < minY)
                {
                    minY = p.Y;
                }
                if (p.X > minX)
                {
                    maxX = p.X;
                }
                if (p.Y > minY)
                {
                    maxY = p.Y;
                }
            }
            return new Tuple<double, double, double, double>(minX, minY, maxX, maxY);
        }
    }
}
