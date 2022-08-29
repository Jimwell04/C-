using System;
using System.Linq;

namespace PythagoreanTheorem
{
	public static class Program
	{
		public static void Main()
		{
			
			// Solution c = square root of (a square + b square)
			
			Console.WriteLine("Pythagorean Theorem C");
			Console.Write("a: ");
			var a = Convert.ToDouble(Console.ReadLine());
			Console.Write("b: ");
			var b = Convert.ToDouble(Console.ReadLine());
			
			var result = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
			Console.WriteLine($"Result: {result}" );
			
		}
	}
}