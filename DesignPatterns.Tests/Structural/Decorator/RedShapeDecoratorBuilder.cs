using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Structural.Decorator;

namespace DesignPatterns.Tests.Decorator
{
	public class RedShapeDecoratorBuilder
	{
		private RedShapeDecorator SUT;

		public RedShapeDecoratorBuilder WithCircle()
		{
			SUT = new RedShapeDecorator(new Circle());
			return this;
		}

		public RedShapeDecoratorBuilder WithRectangle()
		{
			SUT = new RedShapeDecorator(new Rectangle());
			return this;
		}

		public static implicit operator RedShapeDecorator(RedShapeDecoratorBuilder decorator)
		{
			return decorator.SUT;
		}
	}
}
