using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SpecFlowGettingStartedUI.Models
{
	/// <summary>
	///RPN Calculator logic
	/// </summary>
	public class RPNCalculator
	{
		private Stack<decimal> _stack;
		private string[] _items;

		public RPNCalculator(string[] items)
		{
			_stack = new Stack<decimal>();
			_items = items;
		}

		public decimal Calculate()
		{
			decimal firstValue;
			decimal secondValue;

			foreach (var item in _items)
			{
				decimal value = decimal.MinValue;
				decimal.TryParse(item, out value);
				if (value != 0)
				{
					_stack.Push(value);
				}
				else
				{
					switch (item)
					{
						case "+":
							firstValue = _stack.Pop();
							secondValue = _stack.Pop();

							_stack.Push(firstValue + secondValue);
							break;
						case "-":
							firstValue = _stack.Pop();
							secondValue = _stack.Pop();

							_stack.Push(firstValue - secondValue);
							break;
						case "*":
							firstValue = _stack.Pop();
							secondValue = _stack.Pop();

							_stack.Push(firstValue * secondValue);
							break;
						case "/":
							firstValue = _stack.Pop();
							secondValue = _stack.Pop();

							_stack.Push(firstValue / secondValue);
							break;
						case "%":
							firstValue = _stack.Pop();

							_stack.Push(firstValue / 100);
							break;
						case "^":
							firstValue = _stack.Pop();
							secondValue = _stack.Pop();
							var doubleValue = Math.Pow(double.Parse(firstValue.ToString()), double.Parse(secondValue.ToString()));
							_stack.Push(decimal.Parse(doubleValue.ToString()));
							break;
						case "!":
							firstValue = _stack.Pop();
							int fact = 1;
							for (int i = int.Parse(firstValue.ToString()); i >= 1; i--)
							{
								fact = fact * i;
							}
							_stack.Push(decimal.Parse(fact.ToString()));
							break;
						default:
							throw new ArgumentOutOfRangeException($"The input was not expected - {item}");
					}
				}
			}

			return _stack.Pop();
		}
	}
}