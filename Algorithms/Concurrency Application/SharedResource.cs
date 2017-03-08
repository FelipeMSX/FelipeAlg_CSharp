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

		public static int ID { get; set; }

		public int Count { get; set; }

		public int TryAcessIntType;

		public Person Person{ get; set; }

		public Person AnotherPerson {get;set;}


		public void SetPersonWithInstanceLock(String name, int age)
		{
			lock (this)
			{
				Person person = new Person(name,age);
				Thread.Sleep(5000);
			}
		}

		public void SetPersonNormal(String name, int age)
		{
			Person person = new Person(name, age);
			Thread.Sleep(5000);
		}

		public void IncrementNormal()
		{
			Count++;
			Thread.Sleep(5000);
		}

		public void IncrementWithLockType()
		{
			lock (typeof(int))
			{
				Count++;
				Thread.Sleep(5000);
			}
		}

		public void IncrementWithLockInstance()
		{
			lock (this)
			{
				Count++;
				Thread.Sleep(5000);
			}
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
