using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Exceptions
{
	public class EqualsElementException : Exception
	{
		public const string Message = "Equals elements are not allowed!";

        public EqualsElementException()
        {
        }

        public EqualsElementException(string message = null) : base(message ?? Message)
		{
		}

        public EqualsElementException(string message, Exception innerException) : base(message ?? Message, innerException)
        {
        }
    }
}
