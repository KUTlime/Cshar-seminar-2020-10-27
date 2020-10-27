using System;
using System.Collections.Generic;

namespace PointLibrary
{
	public class Utils
	{
		public static Point FindTheFurthest(IEnumerable<Point> array)
		{
			double globalMax = 0;
			Point theFurthestPoint = new Point();
			foreach (var point in array)
			{
				double localMax = point.CalculateDistance(new Point());
				if (localMax > globalMax)
				{
					globalMax = localMax;
					theFurthestPoint = point;
				}
			}
			return theFurthestPoint;
		}

		public static double CalculatePerimeter(IEnumerable<Point> array)
		{
			double perimeter = CalculateDistance(array[^1], array[0]);
			for (int i = 0; i < array.Length - 1; i++)
			{
				perimeter += CalculateDistance(array[i], array[i + 1]);
			}
			return perimeter;
		}

		public static double CalculateDistance(Point p1, Point p2)
		{
			return Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2));
		}
	}

	public class Point
	{
		public Point() : this(0, 0)
		{ }

		public Point(double x, double y)
		{
			X = x;
			Y = y;
		}
		public double X { get; set; }
		public double Y { get; set; }

		public double CalculateDistance(Point point)
		{
			return Utils.CalculateDistance(this, point);
		}

		public override string ToString()
		{
			return $"[{X}; {Y}]";
		}
	}
}
