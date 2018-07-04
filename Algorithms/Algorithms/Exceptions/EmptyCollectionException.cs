using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Exceptions
{
	public class EmptyCollectionException : Exception
	{
		public const string Message = "This collection does not cotain any element!";


        public EmptyCollectionException()
        {
        }

        public EmptyCollectionException(string message = null) : base(message ?? Message)
		{
		}

        public EmptyCollectionException(string message, Exception innerException) : base(message ?? Message, innerException)
        {
        }
    }
}
