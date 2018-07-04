using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Exceptions
{
	public class NullObjectException : Exception
	{
		public const string Message = "Object can't be null!";


        public NullObjectException()
        {
        }

        public NullObjectException(string message = null) : base(message ?? Message)
		{
		}

        public NullObjectException(string message, Exception innerException) : base(message ?? Message, innerException)
        {

        }
    }
}
