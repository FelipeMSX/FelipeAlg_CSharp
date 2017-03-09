using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Concurrency_Application
{


	public class SharedResource
	{

		public const int SLEEP_TIME = 4000;// 4 segundos;

		private int id;
		public int ID
		{
			get
			{
				//lock (typeof(int))
				//{
				return id;
				//}
			}
			set
			{
				//lock (typeof(int))
			//	{
					id = value; 
				//}
			}
		}

		private int count;
		public int Count
		{
			get
			{
				lock (typeof(int))
				{
					int i = 0;
					while (i < 30000)
					{
						i++;
					}
					return count;
				}
			}
			set
			{
				lock (typeof(int))
				{
					int i = 0;
					while (i < 30000)
					{
						i++;
					}
					count = value;
				}
			}
		}

		public int TryAcessIntType;

		public Person Person{ get; set; }

		public Person AnotherPerson {get;set;}


		public void SetPersonWithInstanceLock(String name, int age)
		{
			lock (this)
			{
				Person person = new Person(name,age);
				Thread.Sleep(SLEEP_TIME);
			}
		}

		public void SetPersonNormal(String name, int age)
		{
			Person person = new Person(name, age);
			Thread.Sleep(SLEEP_TIME);
		}

		public void IncrementNormal()
		{
			Thread.Sleep(SLEEP_TIME);
			Count++;
		}

		public void IncrementWithLockType()
		{
			lock (typeof(int))
			{
				Count++;
				Thread.Sleep(SLEEP_TIME);
			}
		}

		public void IncrementWithLockInstance()
		{
			//lock (this)
			//{
				Thread.Sleep(10000);
				Count++;
			
			//}
		}
	}

	public class Person
	{
		public string Name { get; set; }
		public int Age { get; set; }

		public Person(string name, int age)
		{
			Name = name;
			Age = age;
		}
	} 
}
