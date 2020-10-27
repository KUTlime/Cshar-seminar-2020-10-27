using System;
using System.Collections.Generic;
using System.Text.Json;

namespace NumberConversionDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			byte b;

			do
			{
				Console.WriteLine("Please, input number between 0 and 255");
			} while (!Byte.TryParse(Console.ReadLine(), out b));
			Console.WriteLine($"Zadali jste hodnotu {b}");

			byte d = 0;
			ReadByte(in d);
			byte _ = GetByte();
			byte c = d;
			var dictionary = new Dictionary<string, IEnumerable<string>>();
			byte e = d;
		}

		static byte GetByte()
		{
			return 1;
		}

		static void GetByte(byte someByte)
		{
			someByte = 1;
		}

		static void GetByte(out byte someByte)
		{
			someByte = 1;
		}

		static void ReadByte(in byte someByte)
		{
		}
	}
}