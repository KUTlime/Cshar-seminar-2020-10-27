using System;
using System.Collections.Generic;
using PointLibrary;

namespace PointDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			var point1 = new Point();

			var point2 = new Point
			{
				X = 3,
				Y = 4
			};

			var point3 = new Point(-3, -4);
			var point4 = new Point(10, 20);
			Console.WriteLine(Utils.CalculateDistance(point1, point2));
			Console.WriteLine(Utils.CalculateDistance(point1, point3));

			// Ne příliš šťastná varianta jak to pole vyrobit
			// z existujících bodů.
			Point[] pointArray1 = new Point[4];
			pointArray1[0] = point1;
			pointArray1[1] = point2;
			pointArray1[2] = point3;
			pointArray1[3] = point4;

			Point[] pointArray2 = { point1, point2, point3, point4, new Point(20, 30), };

			Console.WriteLine(Utils.CalculatePerimeter(pointArray1));
			Console.WriteLine(Utils.CalculatePerimeter(pointArray2));

			Console.WriteLine($"A distance from origin for point1: {point1.CalculateDistance(new Point(0, 0))}");
			Console.WriteLine($"A distance from origin for point2: {point2.CalculateDistance(new Point(0, 0))}");
			Console.WriteLine($"A distance from origin for point3: {point3.CalculateDistance(new Point(0, 0))}");
			Console.WriteLine($"A distance from origin for point4: {point4.CalculateDistance(new Point(0, 0))}");

			Console.WriteLine(Utils.FindTheFurthest(pointArray2));

			var listOfPoints = new List<Point> { point1, point2, point3 };

			Console.WriteLine(Utils.FindTheFurthest(listOfPoints));
		}
	}
}
