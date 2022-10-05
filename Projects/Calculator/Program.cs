using System;
using System.Linq;

namespace Calculator
{
	public static class Program
	{
		public static void Main()
		{
			
			// CALCULATOR
			
			// Get The Operator
			Console.Write("Operator: ");
			string Operator = Console.ReadLine();
			
			// Get The Numbers Length
			Console.Write("How many Numbers: ");
			var Numbers = Convert.ToInt32(Console.ReadLine());
			
			// Calculation
			double Result = 0;
			var Error = false;
			for (int i = 1; i <= Numbers; i++) {
				
				Console.Write($"Number{i}: ");
				var Num = Convert.ToDouble(Console.ReadLine());
				
				switch (Operator) {
					
					case "+": 
						Result += Num;
						break;
					case "-":
						Result -= Num;
						break;
					case "*": 
						Result *= Num;
						break;
					case "/": 
						Result /= Num;
						break;
					case "%": 
						Result %= Num;
						break;
					default:
						Error = true;
						break;
					
				}
				
				if (Result == 0) {
					Result = Num;
				}
				
			}
			
			// Print the Result
			if (Error) {
				Console.WriteLine("Invalid Input");
			} else {
				Console.WriteLine($"Result: {Result.ToString("N8")}");
			}

		}
	}
}