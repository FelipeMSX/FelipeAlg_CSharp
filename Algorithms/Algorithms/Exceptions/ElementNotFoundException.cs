using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Exceptions
{
	public class ElementNotFoundException : Exception
	{
		public const string Message = "The object can't be found in this collection!";


        public ElementNotFoundException()
        {
        }

        public ElementNotFoundException(string message = null) : base(message ?? Message)
		{
		}

        public ElementNotFoundException(string message, Exception innerException) : base(message ?? Message, innerException)
        {
        }
    }
}
