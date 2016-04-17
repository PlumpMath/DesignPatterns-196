using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Decorator
{
	public class Rectangle : Shape
	{
		public void draw()
		{
			Console.WriteLine("Shape: Rectangle");
		}
	}
}
