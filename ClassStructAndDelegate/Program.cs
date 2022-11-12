using System;
using System.Linq;

namespace ClassStructAndDelegate
{
	class Program
	{
		public static void Main()
		{
			
			var juan = new Person();
			juan.FirstName = "Juan";
			juan.LastName = "Tamad";
			
			var pedro = new Person() {
				
				FirstName = "Pedro",
				LastName = "Sipag"
				
			};
			
			var maria = new Person("Maria");
			var maria2 = new Person("Maria", "Db");
			
			
			Console.WriteLine($@"
			
			Name: {juan.FullName}
			Nickname: {juan.NickName}
			
			");
			
			juan.Update("Juan","Sipag","Masipag");
			
			Console.WriteLine($@"
			
			Name: {juan.FullName}
			Nickname: {juan.NickName}
			
			");
			
			var apple = new Fruit() {
				Name = "Apple",
				Color = "Red"
			};
			
			var mango = new Fruit("Mango","Yellow");
			
		}
	}
}









