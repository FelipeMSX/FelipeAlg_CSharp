using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.exception
{
	class ElementNotFoundException : Exception
	{
		public const string MESSAGE = "The object can't be found in this collection!"; 
		public ElementNotFoundException() : base(MESSAGE)
		{
		}

		public ElementNotFoundException(string message) : base(message)
		{
		}
	}
}
