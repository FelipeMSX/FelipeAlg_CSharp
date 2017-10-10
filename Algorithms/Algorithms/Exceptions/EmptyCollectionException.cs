using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Exceptions
{
	public class EmptyCollectionException : Exception
	{
		public const string MESSAGE = "This collection does not cotain any element!"; 

		public EmptyCollectionException(string message = null) : base(message ?? MESSAGE)
		{
		}
	}
}
