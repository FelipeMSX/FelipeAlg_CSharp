using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.exception
{
	class FullCollectionException : Exception
	{
		public const string MESSAGE = "The collection does not accept any more element"; 
		public FullCollectionException() : base(MESSAGE)
		{
		}

		public FullCollectionException(string message) : base(message)
		{
		}
	}
}
