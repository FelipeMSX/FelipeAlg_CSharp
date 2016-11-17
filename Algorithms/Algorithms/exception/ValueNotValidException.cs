using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.exception
{
	public class ValueNotValidException : Exception
	{
		public const string MESSAGE = "The value is not valid!"; 
		public ValueNotValidException() : base(MESSAGE)
		{
		
		}

		public ValueNotValidException(string message) : base(message)
		{
		}
	}
}
