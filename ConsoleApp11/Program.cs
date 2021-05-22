using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.ForegroundColor = ConsoleColor.Green;
			
			Car b = new Car("Тесла", "Белый", "1200", "Полный","Электро","Седан");
			
			Console.WriteLine("    ");
			b.Off("");
			b.On("");
			b.Rides("");
			Console.WriteLine("    ");


		
			Console.ReadKey();



		}
	}
}
