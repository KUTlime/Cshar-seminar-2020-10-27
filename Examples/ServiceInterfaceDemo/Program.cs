using System;

namespace ServiceInterfaceDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			IServiceMgn service = new ServiceMgnV2();
			service.Register();
			service.Authorize();
			service.DoSomething();
		}
	}


	internal interface IServiceMgn
	{
		void DoSomething();
		void Register();
		void Authorize();
	}

	class ServiceMgnV1 : IServiceMgn
	{
		public void DoSomething()
		{
			Console.WriteLine("Now, I did something.");
		}

		public void Register()
		{
			Console.WriteLine("You have successfully register to our service!");
		}

		public void Authorize()
		{
			Console.WriteLine("You have successfully authorize to use our service!");
		}
	}

	class ServiceMgnV2 : IServiceMgn
	{
		public void MakeSomething()
		{
			Console.WriteLine("Now, I did something.");
		}

		public void RegisterUser()
		{
			Console.WriteLine("You have successfully register to our service!");
		}

		public void AuthorizeUser()
		{
			Console.WriteLine("You have successfully authorize to use our service!");
		}

		public void DoSomething()
		{
			MakeSomething();
		}

		public void Register()
		{
			RegisterUser();
		}

		public void Authorize()
		{
			AuthorizeUser();
		}
	}
}
