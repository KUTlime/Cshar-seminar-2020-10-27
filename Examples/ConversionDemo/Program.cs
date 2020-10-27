using System;

namespace ConversionDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			bool @continue = true;
			do
			{
				Console.WriteLine("Enter the number from 0 to 9");
				switch (Console.ReadLine())
				{
					case "0":
						@continue = PrintLine("zero");
						break;
					case "1":
						@continue = PrintLine("one");
						break;
					case "2":
						@continue = PrintLine("two");
						break;
					default:
						Console.WriteLine("You have entered a wrong character");
						break;
				}
			} while (@continue);
		}

		private static bool PrintLine(string number)
		{
			Console.WriteLine($"You have entered {number}");
			return false;
		}
	}
}
