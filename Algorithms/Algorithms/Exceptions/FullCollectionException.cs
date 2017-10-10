using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Exceptions
{
	public class FullCollectionException : Exception
	{
		public const string MESSAGE = "The collection does not accept any more element"; 

		public FullCollectionException(string message = null) : base(message ?? MESSAGE)
		{
		}
	}
}
