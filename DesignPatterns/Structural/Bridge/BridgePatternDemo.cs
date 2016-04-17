using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge
{
	public class BridgePatternDemo
	{
		public static void Run()
		{
			var redCircle = new Circle(100, 100, 10, new RedCircle());
			var greenCircle = new Circle(100, 100, 10, new GreenCircle());

			redCircle.draw();
			greenCircle.draw();
		}
		

	}
}
