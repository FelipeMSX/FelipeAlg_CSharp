using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Exceptions
{
	public class FullCollectionException : Exception
	{
		public const string Message = "The collection does not accept any more element";

        public FullCollectionException()
        {
        }

        public FullCollectionException(string message = null) : base(message ?? Message)
		{
		}

        public FullCollectionException(string message, Exception innerException) : base(message ?? Message, innerException)
        {
        }
    }
}
