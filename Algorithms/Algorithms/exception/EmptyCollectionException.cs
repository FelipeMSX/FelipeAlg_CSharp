using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.exception
{
	class EmptyCollectionException: Exception
	{
		public EmptyCollectionException() : base() { }
		public EmptyCollectionException(string message) : base(message) { }

		// A constructor is needed for serialization when an
		// exception propagates from a remoting server to the client. 

	}
}
