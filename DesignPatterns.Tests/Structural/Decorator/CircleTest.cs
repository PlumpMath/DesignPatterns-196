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
	public class CircleTest
	{
		private Circle SUT;
		private ConsoleRedirector Redirector;


		[TestInitialize]
		public void Setup()
		{
			SUT = new Circle();
			Redirector = new ConsoleRedirector();
		}

		[TestMethod]
		public void PrintCircleShapeName()
		{
			//Arrange
			var expected = $"Shape: {nameof(Circle)}";

			//Sanity Check Assert
			Assert.IsFalse(Redirector.ToString().Contains(expected));

			//Act
			SUT.draw();

			//Assert
			Assert.IsTrue(Redirector.ToString().Contains(expected));
		}

		[TestCleanup]
		public void TearDown()
		{
			Redirector.Dispose();
			SUT = null;
		}
	}
}
