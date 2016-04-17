using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Decorator
{
	public class ShapeDecoratorDemo
	{
		public static void Run()
		{
			Shape circle = new Circle();

			Shape redCircle = new RedShapeDecorator(new Circle());

			Shape redRectangle = new RedShapeDecorator(new Rectangle());

			Console.WriteLine("Circle with normal border");

			circle.draw();

			Console.WriteLine("\nCircle of red border");

			redCircle.draw();

			Console.WriteLine("\nRectangle of red border");

			redRectangle.draw();
		}
	}
}
