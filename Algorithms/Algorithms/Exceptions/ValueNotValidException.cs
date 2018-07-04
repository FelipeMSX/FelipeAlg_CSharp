using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Exceptions
{
	public class ValueNotValidException : Exception
	{
		public const string MESSAGE = "The value is not valid!";

        public ValueNotValidException()
        {
        }

        public ValueNotValidException(string message = null) : base(message ?? MESSAGE)
		{
		}

        public ValueNotValidException(string message, Exception innerException) : base(message ?? MESSAGE)
        {
        }
    }
}
