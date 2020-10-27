using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using Bank;
using InterfaceDemo;

namespace Smazat20201026
{
	class Program
	{
		static void Main(string[] args)
		{
			/*
			Rectangle r = new Rectangle(0, 0);
			Rectangle square = new Rectangle(10);
			SquareV2 squarev2 = new SquareV2(0);
			Console.WriteLine(r.GetArea());
			Console.WriteLine(r);
			Console.WriteLine(square);

			var circle = new InterfaceDemo.Circle();
			circle.Draw();

			var rec = new InterfaceDemo.Rectangle();
			rec.Draw();

			Shape someShape = new InterfaceDemo.Square();
			someShape.Draw();

			IWidth someEdge = new InterfaceDemo.Rectangle();
			*/
			var account = new Bank.Business.Account();
			var personalAccount = new Bank.Personal.Account();

			var statuses = new List<IStatus>()
			{
				new Bank.Personal.Account()
				{
					BalanceValue = 100
				},
				new Bank.Personal.Account()
				{
					BalanceValue = 1000
				},
				new Bank.Personal.Account()
				{
					BalanceValue = 10000000
				},
				new Bank.Business.Account()
				{
					BalanceValue = 100
				},
				new Bank.Business.Account()
				{
					BalanceValue = 1000
				},
				new Bank.Business.Account()
				{
					BalanceValue = 10000000
				},
				new Bank.Goverment.Account()
				{
					BalanceValue = 0
				}
			};

			foreach (var status in statuses)
			{
				Console.WriteLine(status.GetStatus());
			}
		}
	}

	class Rectangle
	{
		public Rectangle(double width) : this(width, width)
		{
		}

		public Rectangle(double width, double length)
		{
			Width = width;
			Length = length;
		}

		public double Length { get; set; }

		public double Width { get; set; }

		public double GetArea()
		{
			return Length * Width;
		}

		public override string ToString()
		{
			return $"Rectangle width is {Width}, length is {Length}, area is {GetArea()}";
		}
	}

	class Square
	{
		public Square(double length)
		{
			Length = length;
		}

		public double Length { get; set; }

		public double GetArea()
		{
			return Length * Length;
		}

		public override string ToString()
		{
			return $"Square with length {Length}, area {GetArea()}";
		}
	}

	class SquareV2 : Rectangle
	{
		public SquareV2(double width) : base(width, width)
		{
		}
	}
}

namespace InterfaceDemo
{
	abstract class Shape
	{
		public double Area { get; set; }
		public abstract void Draw();
	}

	interface IWidth
	{
		public double Width { get; set; }

		public string Name { get; set; }

		void SayHi();

	}

	class Square : Shape, IWidth
	{
		public double Width { get; set; }
		public string Name { get; set; }
		public void SayHi()
		{
			throw new NotImplementedException();
		}

		public override void Draw()
		{
			Console.WriteLine("This is a square!");
		}
	}

	class Rectangle : Shape, IWidth
	{
		public double Width { get; set; }

		public double Length { get; set; }

		public string Name { get; set; }

		public void SayHi()
		{
			throw new NotImplementedException();
		}

		public override void Draw()
		{
			Console.WriteLine("This is a rectangle!");
		}
	}

	class Circle : Shape
	{
		public override void Draw()
		{
			Console.WriteLine("This is a circle!");

		}
	}
}


namespace Bank
{
	enum Status
	{
		Regular,
		Vip,
		ExtraVip
	}

	class Balance
	{
		public decimal BalanceValue { get; set; }
	}

	interface IStatus
	{
		Status GetStatus();
	}

	namespace Goverment
	{
		class Account : Balance, IStatus
		{
			public Status GetStatus()
			{
				return Status.ExtraVip;
			}
		}
	}

	namespace Business
	{
		class Account : Balance, IStatus
		{
			public Status GetStatus()
			{
				if (BalanceValue > 1_000_000)
				{
					return Status.Vip;
				}
				if (BalanceValue > 10_000_000)
				{
					return Status.ExtraVip;
				}
				return Status.Regular;
			}
		}
	}

	namespace Personal
	{
		class Account : Balance, IStatus
		{
			public Status GetStatus()
			{
				if (BalanceValue > 100_000)
				{
					return Status.Vip;
				}
				if (BalanceValue > 1_000_000)
				{
					return Status.ExtraVip;
				}
				return Status.Regular;
			}
		}
	}
}