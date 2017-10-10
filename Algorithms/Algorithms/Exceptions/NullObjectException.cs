using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Exceptions
{
	public class NullObjectException : Exception
	{
		public const string MESSAGE = "Object can't be null!"; 

		public NullObjectException(string message = null) : base(message ?? MESSAGE)
		{
		}
	}
}
