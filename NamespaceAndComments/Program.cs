using System;
using System.Linq;
using System.Collections;
using NamespaceAndComments.Fruits;
using Other = NamespaceAndComments.Other;

namespace NamespaceAndComments
{
	public static class Program
	{
		public static void Main()
		{
			
			// Namespace
			
			Console.WriteLine("Namespace Testing");
			// This function is under in System namespace
			
			var queue = new Queue();
			// This class is under System.Collections namespace
			
			var banana = new Banana();
			var mango = new NamespaceAndComments.Fruits.Mango();
			// This two class is under NamespaceAndComments.Fruits
			
			var orange = new Other.Orange();
			// This class is under Other variables that's have value of NamespaceAndComments.Other
			// The Orange class is inside Other file
			
			// Comments
			
			// Single Line Comment 
			
			/* 
			    Multi Line Comment
			    Multi Line Comment
			    Multi Line Comment
			*/

		}
	}
}