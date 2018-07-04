using System;
using System.Runtime.Serialization;

namespace Algorithms.Exceptions
{
    public class NullObjectException : Exception, ISerializable
    {
        public new const string Message = "The object can't be null!";

        public NullObjectException() : base(Message)
        {
        }

        public NullObjectException(string message) : base(message ?? Message)
        {
        }

        public NullObjectException(string message, Exception innerException) : base(message ?? Message, innerException)
        {

        }
    }
}
