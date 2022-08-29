using System;
using System.Linq;

namespace Test
{
	public static class Program
	{
		public static void Main()
		{
			
			int x = 10;
			double y = 20;
			
			Console.WriteLine("x = {0}; y = {1}", x, y);
			
			Console.Write("What is your name? ");
			string name = Console.ReadLine();
			
			Console.WriteLine("Hello {0}", name);

		}
	}
}