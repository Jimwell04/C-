using System;
using System.Linq;

namespace VariablesAndDatatypes2
{
	public static class Program
	{
		public static void Main()
		{
			
			#region -- Local Variables --
			
			// Local Variables
			
			// explicit 
			int intNumber = 4;
			
			// implicit
			var varNumber = 4;
			dynamic dynamicNumber = 5;
			
			#endregion
			
			#region -- Variable Scope --
			
			// Variable Scope 
			void Method1() {
				
				int number = 4;
				var varNumber = 5;
				
				// The intNumber is accesible in Method1 and Method2
				intNumber = 5;
				
			}
			
			void Method2() {
				
				int number = 6;
				
				// The variables in Method1 is not accesible in Method2 and vice versa
				
			}
			
			#endregion
			
			// Code Region
			#region -- Region --
			
			void Region() {
				
				var text = "Region";
				
			}
			
			#endregion
			
			#region -- Parse & Convert --
			
			
			void ParseAndConvert() {
				
			// Parse & Convert

			

			// Parse
			string num = "10";
			int intNum = int.Parse(num); 
			int result = intNum * 5;
			Console.WriteLine($"Parse result is {result}");
			
			// Convert
			int converter = Convert.ToInt32(num);
			result = converter * 5;
			Console.WriteLine($"Convert result is {result}");
			
			// If the value is null in Convert it's not error in Parse it's a error
			string nullNum = null;
			int converterNull = Convert.ToInt32(nullNum);
			result = converterNull;
			Console.WriteLine($"Null Convert result is {result}");
				
			}
			
			#endregion
			
		}
		
	}
}