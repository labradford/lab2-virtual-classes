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
                if (Math.Abs(p.X) < Math.Abs(minX))
                {
                    minX = p.X;
                }
                if (Math.Abs(p.Y) < Math.Abs(minY))
                {
                    minY = p.Y;
                }
                if (Math.Abs(p.X) > Math.Abs(minX))
                {
                    maxX = p.X;
                }
                if (Math.Abs(p.Y) > Math.Abs(minY))
                {
                    maxY = p.Y;
                }
            }
            return new Tuple<double, double, double, double>(minX, minY, maxX, maxY);
        }
    }
}
