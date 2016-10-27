using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.exception
{
	class ComparerNotSetException : Exception
	{
		public const string MESSAGE = "Comparer can't be null"; 
		public ComparerNotSetException() : base(MESSAGE)
		{
		
		}

		public ComparerNotSetException(string message) : base(message)
		{
		}
	}
}
