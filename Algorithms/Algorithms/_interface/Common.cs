using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms._interface
{
	interface Common<E>
	{
		/// <summary>
		/// Teste
		/// </summary>
		/// <returns></returns>
		bool Empty();
		E First();
		E Last();
		E Retrive(E obj);	
		void DisposeAll();
	}
}
