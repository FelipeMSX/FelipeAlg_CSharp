using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.exception
{
	class NullObjectException: Exception
	{
		private const string commonMessage = "Não é permitido valor nulo!";
		public NullObjectException() : base(commonMessage) { }
		public NullObjectException(string message) : base(message) { }
	}
}
