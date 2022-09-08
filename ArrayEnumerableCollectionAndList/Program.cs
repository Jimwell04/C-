using System;
using System.Linq;
using System.Collections.Generic; // This for Enumerable, Collection and List

namespace ArrayEnumerableCollectionAndList
{
	public static class Program
	{
		public static void Main()
		{
			
			#region -- Array --
			
			// Array 
			void array() {
			
			// Single Dimensional
			int[] numbers = new int[] {3,4,6,7};
			
			// Multi Dimensional
			int[][] multiNumbers = new int[][] {
				
				new int[] {3,8,7,5},
				new int[] {7,8,4,5},
				new int[] {8,2,5,3}
				
			};
			
			// Jagged
			int[][] jagged = new int[][] {
				
				new int[] {7,5,6,7},
				new int[] {7,5},
				new int[] {8,9,7}
				
			};
			
			// Declaration
			int[] decNumbers = new int[20];
			int[] decNumbersInit = new int[] { 50, 30, 100 };
			int[][] decMultiNumbers = new int[3][] {
				
				new int[] { 40, 98, 45 },
				new int[] { 30, 67, 86 },
				new int[] { 70, 54, 88 }
				
			};
			
			// Using var
			var decNumbersVar = new int[20];

			var decNumbersInitVar = new int[] { 50, 30, 100 };

			var decMultiNumbersVar = new int[3][] {
				
				new int[] { 40, 98, 45 },
				new int[] { 30, 67, 86 },
				new int[] { 70, 54, 88 }
				
			};
			
			var names = new[] { "Jimwell", "Jim", "Jimz" };
			Console.WriteLine("Before");
			foreach (var name in names) {
				
				Console.WriteLine(name);
				
			}
			
			names[0] = "Jack";
			names[1] = "John";
			names[2] = "James";
			
			Console.WriteLine("After");
			foreach (var name in names) {
				
				Console.WriteLine(name);
				
			}
			
			Console.WriteLine($"Names at index 2: {names[2]}");
			
			// Multi-Dimentional
			var rowAndcell = new int[][] {
				
				new[] { 50, 67, 90 },
				new[] { 89, 54, 77 },
				new[] { 87, 66, 87 }
				
			};
			for (var row = 0; row < rowAndcell.Length; row++) {
				
				Console.WriteLine($"Row: {row}");
				
				foreach (var cell in rowAndcell[row]) {
					
					Console.WriteLine(cell);
					
				}
				
			}
			
			}
			
			
			#endregion
			
			#region -- Enumerable, Collection and List --
			
			void EnumerableCollectionList() {
				
				// Enumerable
				
				var countries = new[] { "Philippines", "USA", "Russia", "China", "Japan", "Korea" };
				IEnumerable<string> enumCountries = countries;
				
				// enumCountries[0] = "Error"; This is error IEnumerable is read only
				
				Console.WriteLine("Enumerable");
				foreach (var country in enumCountries) {
					
					Console.WriteLine(country);
					
				}
				
				Console.WriteLine();
				
				// Collection
				
				ICollection<string> colCountries = new List<string>(countries);
				colCountries.Add("India");
				colCountries.Remove("Korea");
				// colCountries[0] = "Error"; this is error ICollection is not index base
				
				Console.WriteLine("Collection");
				foreach (var country in colCountries) {
					
					Console.WriteLine(country);
					
				}
				
				Console.WriteLine();
				
				// List
				
				var listCountries = new List<string>(countries);
				var listCountriesInit = new List<string>() { "UK", "Canada" };
				
				var newListCountries = new List<string>();
				newListCountries.Add("Philippines");
				newListCountries.Add("USA");
				newListCountries.AddRange(new[] { "Japan", "Korea", "China" });
				newListCountries.Remove("China");
				newListCountries[0] = "Your Country";
				
				Console.WriteLine("List");
				for (var index = 0; index < newListCountries.Count; index++) {
					
					Console.WriteLine($"{index}: {newListCountries[index]}");
					
				}
				
			}
			
			#endregion

		}
	}
}