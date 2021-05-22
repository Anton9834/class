using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
	class Car : transport
	{
		public string Privod;
		public string Engine;
		public string View;

		

		public Car(string name, string color, string weight, string privod, string engine, string view) : base(name, color, weight)
		{
			Name = name;
			Color = color;
			Weight = weight;
			Privod = privod;
			Engine = engine;
			View = view;




		}

		internal void Off(string Name)
		{
			Console.WriteLine(Privod + "  " + Engine + " " + View + "  " + base.Name + "  "+base.Color+"  "+ base.Weight+ ": Машина заглушена ");
		}
		internal void On(string Color)
		{
			Console.WriteLine(Privod + "  " + Engine + " " + View + "  " + base.Name + "  " + base.Color + "  " + base.Weight + ": Машина заведена ");
		}

		internal void Rides(string Weight)
		{
			Console.WriteLine(Privod + "  " + Engine + " " + View + "  " + base.Name + "  " + base.Color + "  " + base.Weight + ": Едет ");
		}


	}
}
