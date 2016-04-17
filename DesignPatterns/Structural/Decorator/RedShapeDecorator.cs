﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Decorator
{
	public class RedShapeDecorator : ShapeDecorator
	{
		public RedShapeDecorator(Shape shape) : base(shape){}

		public override void draw()
		{
			base.draw();
			setRedBorder(DecoratedShape);
		}

		private void setRedBorder(Shape decoratedShape)
		{
			Console.WriteLine("Border Color: Red");
		}
	}
}
