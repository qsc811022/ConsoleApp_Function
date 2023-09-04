using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
	class Program
	{
		static void Main(string[] args)
		{
			MyMethod();

			GreetUser("Ted");

			int sum=AddNumbers(1,2);
			Console.WriteLine(sum);


			(int mySum, int myDifference) = AddAndSubtract(10, 5);
			Console.WriteLine($"Sum: {mySum}, Difference: {myDifference}");


		}

		static void MyMethod()
		{
			// do something
		}

		static void GreetUser(string username)
		{
			Console.WriteLine("Hello, " + username);
		}
		static int AddNumbers(int a, int b)
		{
			return a + b;
		}
		static (int sum, int difference) AddAndSubtract(int a, int b)
		{
			return (a + b, a - b);
		}
	}
}
