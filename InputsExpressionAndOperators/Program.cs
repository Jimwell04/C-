using System;
using System.Linq;

namespace InputsExpressionAndOperators
{
    public static class Program
{
	public static void Main()
	{
		
		
		#region -- Input --
		
		void Input() {
			
			// Input
			
			// ReadLine
			Console.Write("Input: ");
			var input = Console.ReadLine();
			Console.WriteLine($"Your Input is: {input}");
			
			// New Line in Console.Write()
			Console.Write($"New Line {Environment.NewLine}");
			Console.Write("New Line \n");
			
			// Read
			Console.Write("Input2: ");
		    var input2 = Console.Read();
		    Console.WriteLine($" \n Your Input2 is: {input2}");
			
			// Convert
			Console.Write($"Input Your Age: ");
			var ageString = Console.ReadLine();
			var age = Convert.ToInt32(ageString);
			
			if (age < 18) 
				Console.WriteLine("Minor");
			else 
				Console.WriteLine("Adult");
			
		}
		
		#endregion
		
		#region -- Operators --
		
		void Operators() {
			
			// Assigment 
			var a = 50;
			a = 10;
			
			// Arithmetic
			
			// Addition 
			var add1 = 8;
			var add2 = 9;
			var add1And2Result = add1 + add2;
			add1And2Result = add1 + add2 + 8 + 9;
			
		    // Subtraction 
			var sub1 = 10;
			var sub2 = 5;
			var sub1And2Result = sub1 - sub2;
			sub1And2Result = sub1 - sub2 - 10 - 5;
			
			// Multiplication
			var mul1 = 2;
			var mul2 = 4;
			var mul1And2Result = mul1 * mul2;
			mul1And2Result = mul1 * mul2 * 2 * 4;
			
			// Divition
			var div1 = 10;
			var div2 = 2;
			var div1And2Result = div1 / div2;
			div1And2Result = div1 / div2 / 10 / 2;
			
			// Modulus
			var mod1 = 9;
			var mod2 = 2;
			var mod1And2Result = mod1 % mod2;
			mod1And2Result = mod1 % mod2 % 9 % 2;
			
			// Precedence : (), [], ++, --, *, /, %, +, -
			var many = (2 * 3) + 100 / 5 * 250;
			Console.WriteLine(many);
			
			
			// Boolean
			var bool1 = true;
			var bool2 = false;
			
			var test1 = bool1 && bool2;
			var test2 = bool1 || bool2;
			
			// Equality
			var eq1 = 10;
			var eq2 = 5;
			
			var testEq = eq1 == eq1;
			var testNotEq = eq1 != eq2;
			
			var testGreatherEq = eq1 > eq2;
			var testLessthanEq = eq1 < eq2;
			
			var testGreatherOrEq = eq1 >= eq2;
			var testLessthanOrEq = eq1 <= eq2;
			
			// Null-Coalescing
			var col1 = "Have Value";
			string col2 = null;
			
			var testCol1 = col1 ?? "Have Given Value";
			var testCol2 = col2 ?? "Have Given Value";
			
			Console.WriteLine(testCol1);
			Console.WriteLine(testCol2);
			
			// Unary
			var una = true;
			var notUna = !una;
			
			var increment = 5;
			
			// Post
			Console.WriteLine(increment++);
			// This is equivalent to increment = increment + 1
			
			// Pre
			Console.WriteLine(++increment);
			
			var decrement = 10;
			
			// Post
			Console.WriteLine(decrement--);
		    // This is equivalent to decrement = decrement - 1
		    
		    // Pre
		    Console.WriteLine(--decrement);

			// Ternary
			var ter = "Jim";              // True      // False
			var testTer = ter == "Jim" ? "Jimwell" : "Not Jimwell";
			Console.WriteLine(testTer);
			
		}
		
		
		#endregion

	}
}
}