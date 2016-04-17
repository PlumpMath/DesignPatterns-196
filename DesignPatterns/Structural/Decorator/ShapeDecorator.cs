using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Decorator
{
	public abstract class ShapeDecorator : Shape
	{
		protected Shape DecoratedShape;
		public ShapeDecorator(Shape decoratedShape)
		{
			DecoratedShape = decoratedShape;
		}

		public virtual void draw()
		{
			DecoratedShape.draw();
		}
	}
}
