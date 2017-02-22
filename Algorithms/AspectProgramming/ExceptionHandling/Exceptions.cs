using System;
using System.Reflection;
using System.Text;
using PostSharp.Aspects;
using PostSharp.Extensibility;
using PostSharp.Serialization;

namespace AspectProgramming.ExceptionHandling
{
	[PSerializable]
	public sealed class NullException : OnExceptionAspect
	{
		/// <summary>
		///     Method invoked when the target method fails with an exception.
		/// </summary>
		/// <param name="args">Method invocation context.</param>
		public override void OnException(MethodExecutionArgs args)
		{
			
		}

		public override Type GetExceptionType(MethodBase targetMethod)
		{
			return typeof( NullReferenceException);
		}
	}

	[PSerializable]
	public sealed class SqlException : OnExceptionAspect
	{
		/// <summary>
		///     Method invoked when the target method fails with an exception.
		/// </summary>
		/// <param name="args">Method invocation context.</param>
		public override void OnException(MethodExecutionArgs args)
		{
		}
		// TODO: For better performance, delete any method that the aspect does not use.
	}
}
