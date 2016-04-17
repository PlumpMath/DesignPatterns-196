using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Structural.Bridge;

namespace DesignPatterns.Tests.Structural.Bridge
{
	public class CircleBuilder 
	{
		private Circle _Circle;

		public int X { get; set; }
		public int Y { get; set; }
		public int Radius { get; set; }
		
		public CircleBuilder WithDimensions(int x, int y, int radius)
		{
			this.X = x;
			this.Y = y;
			this.Radius = radius;

			return this;
		}

		public CircleBuilder WithRedAPI()
		{
			_Circle = new Circle(X, Y, Radius, new RedCircle());
			return this;
		}

		public CircleBuilder WithGreenAPI()
		{
			_Circle = new Circle(X, Y, Radius, new GreenCircle());
			return this;
		}

		public static implicit operator Circle(CircleBuilder decorator)
		{
			return decorator._Circle;
		}
	}


}
