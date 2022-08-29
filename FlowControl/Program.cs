using System;
using System.Linq;

namespace FlowControl
{
	public static class Program
	{
		public static void Main()
		{
			
			// Flow Control
			
			void FlowControl() {
				
				// If Else
				#region -- If Else --
				
				const int MAX_MINOR_AGE = 17;
				const int MIN_SENIOR_AGE = 60;
				
				var isPWD = true;
				var age = 18;
				
				if (age <= MAX_MINOR_AGE || age >= MIN_SENIOR_AGE) {
					
					Console.WriteLine("Add minor or senior discount");
					
				} else if (isPWD) {
					
					Console.WriteLine("Add PWD discount");
					
				} else {
					
					Console.WriteLine("No discount");
					
				}
				
				#endregion
				
				
				// Switch
				#region -- Switch -- 
				
				switch (age) {
					
					case 1:
						Console.WriteLine("Baby");
						break;
					case 10:
					case 11:
					case 12:
					case 13:
					case 14:
					case 15:
					case 16:
					case 17:
					case 18:
					case 19:
						Console.WriteLine("Teen");
						break;
					default: 
						Console.WriteLine("Unknow");
						break;
					
					
				}
				
				#endregion
				
				#region -- While --
				
				// While
				var count = 0;
				while (count < 5) {
					
					count++;
					Console.WriteLine(count);
				
				}
				
				#endregion
				
				#region -- Do While --
				
				// Do While 
				count = 3;
				
				do {
					
					Console.WriteLine(count);
					count++;
					
				} while (count < 3);
				
				#endregion
				
				#region -- For Loop --
				
				// For Loop
				
				for (int i = 0; i <= 10; i++) {
					
					Console.WriteLine(i);
					
				}
				
				#endregion
				
				#region -- Foreach --
				
				var array = new[] { "Jimwell", "Jim", "Jimz" };
				
				foreach (var value in array) {
					
					Console.WriteLine(value);
					
				}
				
				#endregion
				
			}
			
			FlowControl();
			
		}
	}
}