using System;
using System.Runtime.Serialization;

namespace Algorithms.Exceptions
{
	public class ComparerNotSetException : Exception, ISerializable
    {
		public new const string Message = "Comparer can't be null";

        public ComparerNotSetException() : base(Message)
        {
        }

        public ComparerNotSetException(string message) : base(message ?? Message)
		{
		}

        public ComparerNotSetException(string message, Exception innerException) : base(message ?? Message, innerException)
        {
        }
    }
}
