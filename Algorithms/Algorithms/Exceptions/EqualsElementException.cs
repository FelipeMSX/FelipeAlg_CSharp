using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Exceptions
{
	public class EqualsElementException : Exception
	{
		public const string MESSAGE = "Equals elements are not allowed!";

        public EqualsElementException()
        {
        }

        public EqualsElementException(string message = null) : base(message ?? MESSAGE)
		{
		}

        public EqualsElementException(string message, Exception innerException) : base(message ?? MESSAGE)
        {
        }
    }
}
