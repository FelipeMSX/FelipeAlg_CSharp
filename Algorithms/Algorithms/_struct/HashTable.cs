using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms._interface;

namespace Algorithms._struct
{
	public class HashTable <Key, Value> : IEnumerable<KeyValue<Key, Value>>
	{
		/// <summary>
		/// Constante que define um valor inicial padrão para a coleção.
		/// </summary>
		public readonly int DEFAULT_SIZE = 1000;

		/// <summary>
		///
		/// </summary>
		protected LinkedList<KeyValue<Key, Value>>[] KeyValues { get; set; }

		/// <summary>
		/// Obtém o tamanho atual da coleção.
		/// </summary>
		public int Length { get; private set; }

		public int Capacity { get; private set; }

		public IDefaultComparator<Key> EComparer;

		public HashTable(int capacity, IDefaultComparator<Key> eComparer)
		{
			KeyValues = new LinkedList<KeyValue<Key, Value>>[capacity];
			EComparer = eComparer;
			Capacity  = capacity;
		}

		public HashTable(IDefaultComparator<Key> eComparer)
		{
			KeyValues = new LinkedList<KeyValue<Key, Value>>[DEFAULT_SIZE];
			EComparer = eComparer;
			Capacity = DEFAULT_SIZE;
		}

		protected int HashFuction(Key key) => key.GetHashCode() % Capacity;	

		public void Put(Key key, Value value)
		{
			int hashCode = HashFuction(key);
			KeyValues[hashCode].Insert(new KeyValue<Key, Value>(key, value));
		}

		public Value Remove(Key key)
		{
			int hashCode = HashFuction(key);
			
		}



		public IEnumerator<KeyValue<Key, Value>> GetEnumerator()
		{
			
			throw new NotImplementedException();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			throw new NotImplementedException();
		}
	}

	public struct KeyValue<E, V>
	{
		public E Key { get; set; }
		public V Value { get; set; }

		public KeyValue(E key, V Value)
		{
			Key = key;
			Value = value;
		}
	}
}
}
