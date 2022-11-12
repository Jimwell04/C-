using System;
using System.Linq;

namespace StringDateTimeNullableAndEnumeration
{
	public static class Program
	{
		public static void Main()
		{
			
			void String1() {
				
			// String

			#region -- string -- 

			
			string name = "Jimwell";
			
			foreach (char i in name) {
				Console.WriteLine(i);
			}
			
			string name1; // null
			string name2 = null; // null
			
			Console.WriteLine();
			
			name += " Ibay";
			foreach (char i in name) {
				Console.WriteLine(i);
			}
			
			Console.WriteLine();
			
			char[] name3 = name.ToCharArray();
			Console.WriteLine(name3);
			
			string name4 = new String(name3);
			Console.WriteLine(name4);
			
			string name5 = @"""Jimwell/Ibay""";
			Console.WriteLine(name5);
			
			name5 = @"J
			i
			m
			w
			e
			l
			l";
			Console.WriteLine(name5);
			
			string name6 = "Your\tname\tis\nJimwell\tIbay";
			Console.WriteLine(name6);
			
			/*
			
			Numeric Standard Formatting
			C = Currency
			N = Number
			P = Percent
			
			D = Decimal
			
			*/
			
			Console.WriteLine();
			
			var numeric = 12345.678D;
			Console.WriteLine(numeric.ToString("C"));
			Console.WriteLine(numeric.ToString("N"));
			Console.WriteLine(numeric.ToString("P"));
			
			var numeric1 = 123;
			Console.WriteLine(numeric1.ToString("D10"));
			
			// Two Decimal Point
			Console.WriteLine(numeric1.ToString("N2"));
			
			// String Formating
			string formating = string.Format("Name: {0}, Age: {1}", name, 17);
			Console.WriteLine(formating);
			
			// Checking String
			string check = null;
			
			if (!string.IsNullOrEmpty(check)) {
				Console.WriteLine("Have value");
			} else {
				Console.WriteLine("No value");
			}
			
			#endregion

			}
			
			void DateTime1() {
				
				// Date and Time
				#region -- Date and Time --
				
				var now = DateTime.Now;
				var today = DateTime.Today;
				var timeNow = now.TimeOfDay;
				var dateNow = now.Date;
				
				Console.WriteLine($"Now: {now}");
				Console.WriteLine($"Today: {today}");
				Console.WriteLine($"Time Now: {timeNow}");
				Console.WriteLine($"Date Now: {dateNow}");
				
				#endregion
				
			}
			
			void Nullable1() {
				
				// Nullable
				
				#region -- Nullable --
				
				string myString = null;
				Nullable<int> myInt = null;
				int? myInt1 = null;
				
				if (myInt.HasValue) {
					Console.WriteLine(myInt.Value);
				} else {
					Console.WriteLine(myInt1);
				}
									
				#endregion
				
			}
			
			void Enumeration() {
				
				// Enumeration
				
				#region -- Enumeration --
				
				var gender1 = Gender.Male;
				var gender2 = Gender.Female;
				var gender3 = Gender.Unknown;
				Console.WriteLine($"Gender: {gender1} Value: {(int)gender1}");
				
				int num = 1;
				Gender genderValue = (Gender)num;
				Console.WriteLine(genderValue);
				
				#endregion
				
			}
			
		}
		
		public enum Gender {
			Male,
			Female = 2,
			Unknown = 1
		}
		
	}
}