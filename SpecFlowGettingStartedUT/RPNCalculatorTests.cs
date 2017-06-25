using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SpecFlowGettingStartedUI.Models;

namespace SpecFlowGettingStartedUT
{
	[TestClass]
	public class RPNCalculatorTests
	{
		[TestMethod]
		public void DecimalCalculationGivesRightResults()
		{
			var values = new string[] { "2.5","3.5","+" };
			var rpnCalculator = new RPNCalculator(values);

			var result  = rpnCalculator.Calculate();

			Assert.AreEqual(result, 6);
		}

		[TestMethod]
		public void PercentageCalculationGivesRightResults()
		{
			var values = new string[] { "2", "%" };
			var rpnCalculator = new RPNCalculator(values);

			var result = rpnCalculator.Calculate();

			Assert.AreEqual(result, decimal.Parse(0.02.ToString()));
		}

		[TestMethod]
		public void SquareCalculationGivesRightResults()
		{
			var values = new string[] { "2", "3", "^" };
			var rpnCalculator = new RPNCalculator(values);

			var result = rpnCalculator.Calculate();

			Assert.AreEqual(result, 9);
		}

		[TestMethod]
		public void FactorialCalculationGivesRightResults()
		{
			var values = new string[] { "4", "!" };
			var rpnCalculator = new RPNCalculator(values);

			var result = rpnCalculator.Calculate();

			Assert.AreEqual(result, 24);
		}

		[TestMethod]
		public void AdditionCalculationGivesRightResults()
		{
			var values = new string[] { "2", "3" , "+"};
			var rpnCalculator = new RPNCalculator(values);

			var result = rpnCalculator.Calculate();

			Assert.AreEqual(result, 5);
		}

		[TestMethod]
		public void SubtractionCalculationGivesRightResults()
		{
			var values = new string[] { "2", "3", "-" };
			var rpnCalculator = new RPNCalculator(values);

			var result = rpnCalculator.Calculate();

			Assert.AreEqual(result, 1);
		}

		[TestMethod]
		public void MultiplicationCalculationGivesRightResults()
		{
			var values = new string[] { "2", "3", "*" };
			var rpnCalculator = new RPNCalculator(values);

			var result = rpnCalculator.Calculate();

			Assert.AreEqual(result, 6);
		}

		[TestMethod]
		public void DivisionCalculationGivesRightResults()
		{
			var values = new string[] { "2", "3", "/" };
			var rpnCalculator = new RPNCalculator(values);

			var result = rpnCalculator.Calculate();

			Assert.AreEqual(result, decimal.Parse(1.5.ToString()));
		}
	}
}
