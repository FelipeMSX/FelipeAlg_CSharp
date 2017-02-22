using System;
using System.Reflection;
using _3tn.Dados;
using AspectProgramming.Objects;
using PostSharp.Aspects;
using PostSharp.Extensibility;
using PostSharp.Serialization;

namespace AspectProgramming.Transaction
{
	[PSerializable]
	public sealed class OnTransationAspect : OnMethodBoundaryAspect
	{
		#region Build-Time Logic

		public OnTransationAspect()
		{
		}

		public override bool CompileTimeValidate(MethodBase method)
		{
			// TODO: Check that the aspect has been applied on a proper method.

			if (false)
			{
				Message.Write(method, SeverityType.Error, "MY001", "Cannot apply OnTransationAspect to method '{0}'.", method);
				return false;
			}

			return true;
		}

		public override void CompileTimeInitialize(MethodBase method, AspectInfo aspectInfo)
		{
			// TODO: Initialize any instance field whose value only depends on the method to which the aspect is applied.
		}

		#endregion


		public override void RuntimeInitialize(MethodBase method)
		{
			// This method is invoked once at run time.
		}

		public override void OnEntry(MethodExecutionArgs args)
		{
			Abastecimento abastecimento =  (Abastecimento)args.Instance;
			abastecimento.AcessoDados.IniciarTransacao();
			//clsAcessoDados D = (acessoDados != null) ? acessoDados : new clsAcessoDados();
			//  This method is invoked before the execution of the method to which the current aspect is applied.

			// args.Instance contains the object whose method is being executed (null if the method is static).
			// args.Arguments contains method arguments.

			// Set args.FlowBehavior = FlowBehavior.Return to return to the caller without executing the intercepted method.
			// In this case, set args.ReturnValue to a value that is compatible to the return type of the method (null for void methods).

		}

		public override void OnExit(MethodExecutionArgs args)
		{
			Abastecimento abastecimento = (Abastecimento)args.Instance;
			abastecimento.AcessoDados.FecharConexao();
			// This method is invoked after the execution of the method to which the current aspect is applied (both on success and on exception).
			// It is equivalent to the 'finally' block.

			// args.Instance contains the object whose method is being executed (null if the method is static).
			// args.Arguments contains method arguments.
			// args.ReturnValue contains the return value in case of successful execution.
			// args.Exception contains the current exception (if any).

		}

		public override void OnSuccess(MethodExecutionArgs args)
		{
			var obj = args;
			// This method is invoked after successful execution of the method to which the current aspect is applied.
			// It is equivalent to the 'finally' block.

			// args.Instance contains the object whose method is being executed (null if the method is static).
			// args.Arguments contains method arguments.
			// args.ReturnValue contains the return value in case of successful execution.
		}

		// TODO: For better performance, delete any method that the aspect does not use.
	}
}
