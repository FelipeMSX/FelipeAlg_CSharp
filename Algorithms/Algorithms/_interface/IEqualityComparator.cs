using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms._interface
{
	/// <summary>
	/// Define um modo de comparação entre dois objetos.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public interface IEqualityComparator<T>
	{
		bool Equals(T x, T y);

		int GetHashCode(T obj);

	}
}
