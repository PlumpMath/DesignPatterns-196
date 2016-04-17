using System;
using DesignPatterns.Structural.Bridge;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatterns.Tests.Structural.Bridge
{
	[TestClass]
	public class CircleTest
	{
		private Circle SUT;
		private ConsoleRedirector Redirector;
		private int radius, x, y;

		[TestInitialize]
		public void Setup()
		{
			Redirector = new ConsoleRedirector();

			radius = 200;
			x = 150;
			y = 150;
		}

		[TestCleanup]
		public void TearDown()
		{
			Redirector.Dispose();
			SUT = null;
		}

		[TestMethod]
		public void ShouldPrintCorrectColorWithRedAPI()
		{
			var expected = $"Drawing Circle [ color: red, radius: {radius} x: {x}, y: {y}";

			SUT = new CircleBuilder().WithDimensions(x: x, y: y, radius: radius).WithRedAPI();

			SUT.draw();

			Assert.IsTrue(Redirector.ToString().Contains(expected));
		}

		[TestMethod]
		public void ShouldPrintCorrectColorWithGreenAPI()
		{
			var expected = $"Drawing Circle [ color: green, radius: {radius} x: {x}, y: {y}";

			SUT = new CircleBuilder().WithDimensions(radius: radius, x: x, y: y).WithGreenAPI();

			SUT.draw();

			Assert.IsTrue(Redirector.ToString().Contains(expected));
		}
	}
}
