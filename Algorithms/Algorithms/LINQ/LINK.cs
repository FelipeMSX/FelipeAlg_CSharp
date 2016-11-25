using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.LINQ
{
	public interface LINK<out E>
	{
		 IEnumerator<E> GetEnumerator();
		
	}


}
