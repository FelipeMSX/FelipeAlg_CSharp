using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.exception
{
	class FullCollectionException: Exception
	{
		private const string commonMessage = "A coleção de itens está cheia!";
		public FullCollectionException() : base(commonMessage) { }
		public FullCollectionException(string message) : base(message) { }
	}
}
