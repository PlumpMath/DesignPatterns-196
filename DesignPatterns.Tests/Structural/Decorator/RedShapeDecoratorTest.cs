using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Structural.Decorator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatterns.Tests.Decorator
{
	[TestClass]
	public class RedShapeDecoratorTest
	{
		private RedShapeDecorator SUT;
		private ConsoleRedirector Redirector;

		[TestInitialize]
		public void Setup()
		{
			Redirector = new ConsoleRedirector();
		}

		[TestMethod]
		public void PrintRedCircleName()
		{
			//Arrange
			SUT = new RedShapeDecoratorBuilder().WithCircle();

			var expected = $"Shape: {nameof(Circle)}";
			var expected2 = $"Border Color: Red";

			//Act
			SUT.draw();

			//Assert: 1 Logical assertion
			Assert.IsTrue(Redirector.ToString().Contains(expected));
			Assert.IsTrue(Redirector.ToString().Contains(expected2));

		}

		[TestMethod]
		public void PrintRedRectangleName()
		{
			//Arrange
			SUT = new RedShapeDecoratorBuilder().WithRectangle();

			var expected = $"Shape: {nameof(Rectangle)}";
			var expected2 = $"Border Color: Red";

			//Act
			SUT.draw();

			//Assert: 1 Logical assertion
			Assert.IsTrue(Redirector.ToString().Contains(expected));
			Assert.IsTrue(Redirector.ToString().Contains(expected2));
		}

		[TestCleanup]
		public void TearDown()
		{
			Redirector.Dispose();
			SUT = null;
		}

	}
}
