using System;
using System.Linq;

namespace FunctionAndParameters
{
	class Program
	{
		public static void Main()
		{
			
			// Function and Parameters
			
			var program = new Program();
			program.PrintName();
			program.PrintMyName("Zep");
			program.PrintNames("Zep", "Jimwell", "Jimz");
			program.Data();
			program.Data("Alex",45);
			program.Data(age: 18);
			program.Print("45");
			var x = program.Read();
			program.Print(x.ToString());
			
			var mod = "Text";
			program.Modify(ref mod);
			program.Print(mod);
			
			var fac = program.Factorial(10);
			program.Print(fac.ToString());
			

		}
		public void PrintName() {
			
			Console.WriteLine("The name is Jimwell Ibay");
			
		}
		public void PrintMyName(string name) {
			
			Console.WriteLine($"Your name is {name}");
			
		}
		public void PrintNames(params string[] names) {
			
			Console.WriteLine(string.Join(" | ", names));
			
		}
		public void Data(string name = "Jimwell", int age = 17) {
			
			Console.WriteLine($"Name: {name} \n Age: {age}");
			
		}
		public void Print(string val = null) => Console.WriteLine(val);
		
		public string Read() {
			string val = Console.ReadLine();
			return val;
		}
		public void Modify(ref string mod) {
			
			mod = "!Modified Text!";
			
		}
		public int Factorial(int number) {
			
			if (number == 1)
			   return number;
			   
			   
			return number * Factorial(number - 1);
		}
}
}










