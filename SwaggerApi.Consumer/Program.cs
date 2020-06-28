using IO.Swagger.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SwaggerApi.Consumer
{
    class Program
    {
		public static LibraryApi instance;

		public static void Init()
		{
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

			instance = new LibraryApi();
			instance.Configuration.BasePath = "https://localhost:44344/";
		}


		public static void Menu()
		{
			Console.Clear();

			Console.WriteLine("(A) Exho Test");
			Console.WriteLine("(B) Exho Test");
			Console.WriteLine("");
		}

		public static void EchoTest()
		{
			Console.Clear();
			Console.WriteLine("What text should we exho test?");
			var echoValue = Console.ReadLine();

			var response = instance.LibraryEchoTest(echoValue);

			Console.Clear();
			Console.WriteLine("The echo response is:");
			Console.WriteLine(response);

			Console.ReadKey();
		}

		public static void SearchBooks()
		{
			Console.Clear();
			Console.WriteLine("Which title should we search for");
			var echoValue = Console.ReadLine();

			var response = instance.LibrarySearchLibrary(new IO.Swagger.Model.SearchLibraryRequest() {TitleName = echoValue });

			Console.Clear();
			Console.WriteLine("The echo response is:");
			foreach(var book in response.Books)
			{
				var availableFormats = new List<string>();

				foreach(var format in book.AvailableFormats)
				{
					availableFormats.Add(format.ToString());
				}

				Console.WriteLine($"Book: {book.Title}, Author: {book.Author}, Format: {string.Join(";", availableFormats)}");
			}

			Console.WriteLine(response.Outcome);
			Console.ReadKey();
		}


		public static void Main(string[] args)
		{
			Init();
			var exit = false;

			while (!exit)
			{
				Menu();

				Console.WriteLine("Press escape to exit");
				var keypressed = Console.ReadKey().Key;
				switch (keypressed)
				{
					case ConsoleKey.A:
						EchoTest();
						break;

					case ConsoleKey.B:
						SearchBooks();
						break;

					case ConsoleKey.Escape:
						exit = true;
						break;
				}
			}
		}
	}
}
