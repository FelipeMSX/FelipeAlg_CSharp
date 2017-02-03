using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concurrency_Application
{
	public class TaskStudy
	{
		int timeToRelease = 1000;
		int inicial = 2;

		private static int balance = 50;
		public static int Balance
		{
			get { return balance; }
			set
			{
				lock ("balance")
				{
					balance = value;
				}
			}
		}

		public int CalcManyTimes()
		{
			int i = 0;
			while (i < 1000000000)
			{
				i++;
			}
			inicial++;
			return inicial + 5;
		}
		public async Task<int> ObserveOneExceptionAsync()
		{
			int result = await Task<int>.Run(() => CalcManyTimes());

			try
			{

			}
			catch (Exception ex)
			{
				// "ex" is either NotImplementedException or InvalidOperationException.

			}
			return result;
		}

	}
}
