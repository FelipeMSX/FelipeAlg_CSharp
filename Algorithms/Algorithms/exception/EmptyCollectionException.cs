using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.exception
{
	class EmptyCollectionException : Exception
	{
		public const string MESSAGE = "This collection does not cotain any element!"; 
		public EmptyCollectionException() : base(MESSAGE)
		{
		}

		public EmptyCollectionException(string message) : base(message)
		{
		}
	}
}
