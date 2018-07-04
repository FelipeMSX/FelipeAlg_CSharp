using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Exceptions
{
	public class ComparerNotSetException : Exception
	{
		public const string Message = "Comparer can't be null";

        public ComparerNotSetException()
        {
        }

        public ComparerNotSetException(string message = null) : base(message ?? Message)
		{
		}

        public ComparerNotSetException(string message, Exception innerException) : base(message ?? Message, innerException)
        {
        }
    }
}
