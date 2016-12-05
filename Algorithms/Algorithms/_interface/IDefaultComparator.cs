using System;

namespace Algorithms._interface
{
	public interface IDefaultComparator<E>
	{
		Comparison<E> Comparator { get; set; }
	}
}
