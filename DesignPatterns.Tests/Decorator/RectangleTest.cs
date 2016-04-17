using System;
using DesignPatterns.Structural.Decorator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatterns.Tests.Decorator
{
	[TestClass]
	public class RectangleTest
	{
		private Rectangle SUT;
		private ConsoleRedirector Redirector;
		
		[TestInitialize]
		public void Setup()
		{
			SUT = new Rectangle();
			Redirector = new ConsoleRedirector();
		}

		[TestMethod]
		public void PrintRectangleShapeName()
		{
			//Arrange
			var expected = $"Shape: {nameof(Rectangle)}";

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
