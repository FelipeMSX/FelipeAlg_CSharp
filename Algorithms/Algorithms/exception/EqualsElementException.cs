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

		public EqualsElementException(string message = null) : base(message ?? MESSAGE)
		{
		}
	}
}
