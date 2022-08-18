using System;
using System.Linq;

namespace VariablesAndDatatypes1
{
	public static class Program
	{
		public static void Main()
		{
			
			static void HaveKissNoKiss() {
				
				// NO KISS
				Console.WriteLine("NO KISS");
				int number = 100;
				string stringNumber = ConvertToString(number);
				Console.WriteLine(stringNumber);
				
				string ConvertToString(int number) {
					
					
					return number.ToString();
				}
				
				// HAVE KISS
				Console.WriteLine("HAVE KISS");
				int numberKiss = 100;
				Console.WriteLine(numberKiss);
				
				// KISS - Keep It Simple Stupid
				
			}
			
			static void DAMP() {
				
				// DAMP
				Console.WriteLine("DAMP");
				int a = 50;
				Console.WriteLine($"The Number of Apples is: {a}");
				// This principle is not specific 
				
				int numberOfApples = 50;
				Console.WriteLine($"The Number of Apples is: {numberOfApples}");
				// The DAMP principle is specific
				
				// DAMP - Descriptive And Meaningful Phrases
				
			}
			
			static void WetAndDry() {
				
				// WET 
				Console.WriteLine("WET");
				
				int a = 1;
				int b = 2;
				int c = 3;
				int d = 4;
				
				Console.WriteLine($"a + b = {a + b}");
				Console.WriteLine($"c + d = {c + d}");
				Console.WriteLine("Violated the WET");
				Console.WriteLine($"c + d = {c + d}");
				// This is violated the WET principle because the process is more than 2 times repeated
				
				// DRY
				// Use DRY principle instead
				
				Console.WriteLine("DRY");
				AddAndPrint("a + b", a, b);
				AddAndPrint("a + b", c, d);
				AddAndPrint("a + b", c, d);
				
				void AddAndPrint(string text, int firstNumber, int secondNumber) {
					
					Console.WriteLine($"{text} = {firstNumber + secondNumber}");
					
				}
				
				// WET - Write Everything Twice
				// DRY - Do Not Repeat Yourself
				
			}
			
			static void Variables() {
				
				// Variables 
				
				int mNumber1, mNumber2, mNumber3; // Multiple
				
				// Single Per Line
				int sNumber1;
				int sNumber2;
				int sNumber3;
				
				// Declerataion
				short dNumber1 = 1;
				int dNumber2 = 2;
				long dNumber3 = 3;
				
				dNumber2 = dNumber1;
				dNumber3 = dNumber2;
				
				var addIntAndLong = dNumber2 + dNumber3;
				
				bool dBoolean1 = true;
				bool dBoolean2 = false;
				
				char dChar = 'C';
				
				string dString1;
				string dString2 = "String";
				
				float dFloat = 1.25F;
				double dDouble = 2.25D;
				dDouble = dFloat;
				
				var addFloatAndDouble = dFloat + dDouble;
				
				decimal dDecimal = 3.25M;
				
			}

		}
	}
}