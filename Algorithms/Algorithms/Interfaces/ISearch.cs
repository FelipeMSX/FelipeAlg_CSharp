using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Interfaces
{
    public interface ISearch
    {
        E BinarySearch<E>(IList<E> orderedArray, E item, IDefaultComparator<E> comparator);
    }
}
