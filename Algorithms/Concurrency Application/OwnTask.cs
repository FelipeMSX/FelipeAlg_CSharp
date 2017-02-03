using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Concurrency_Application
{
	public class OwnTask
	{

		public CancellationTokenSource CancellationToken { get; private set; } = new CancellationTokenSource();


		public int Teste()
		{
			return 0;
		}


	}
}
