using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms._interface
{
	public interface DefaultComparator<E>
	{
		Comparison<E> Comparator { get; set; }
	}
}
