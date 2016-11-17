using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.exception
{
	public class EqualsElementException : Exception
	{
		public const string MESSAGE = "Equals elements are not allowed!"; 
		public EqualsElementException() : base(MESSAGE)
		{
		}

		public EqualsElementException(string message) : base(message)
		{
		}
	}
}
