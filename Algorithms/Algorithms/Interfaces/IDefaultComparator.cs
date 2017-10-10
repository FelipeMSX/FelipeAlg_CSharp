using System;

namespace Algorithms.Interfaces
{
	public interface IDefaultComparator<E>
	{
		Comparison<E> Comparator { get; set; }
	}
}
