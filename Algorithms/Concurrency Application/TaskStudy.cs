using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concurrency_Application
{
	public  class TaskStudy
	{
		int timeToRelease = 1000;
		public int total = 0;
		public async Task<int> Somar(int acumulado)
		{
			Task<int> t = new Task<int>(() =>
			{
				int i = 0;

		
			
				return 1;
			}
			);
			total += acumulado;
			return await t;
		}
	}


}
