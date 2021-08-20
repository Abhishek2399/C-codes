using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace ConsoleApp1
{
	class Person
	{
		public string Name { get; set; }
		public string Address { get; set; }
		public int Age { get; set; }
	}

	class PersonImplementation : Person
	{

		public string GetName(IList<Person> person)
		{
			string info = "";
			foreach (var data in person)
			{
				info += $"{data.Name} {data.Address} ";
			}
			return info;
		}

		public double Average(IList<Person> person)
		{
			double avg=0;
			foreach (var data in person)
			{
				avg += data.Age;
			}
			return avg/person.Count;
		}

		public int Max(IList<Person> person)
		{
			int maxAge = 0;
			try
			{
				foreach (var data in person)
				{
					if (data.Age > maxAge)
					{
						maxAge = data.Age;
					}
				}
			}
			catch(Exception ex)
            {
				throw ex;
            }
			return maxAge;
		}
	}

	class Source
	{
		static void Main()
		{
			try
			{
				IList<Person> p = new List<Person>();
				p.Add(new Person { Name = "Aarya", Address = "A2101", Age = 69 });
				p.Add(new Person { Name = "Daniel", Address = "D104", Age = 40 });
				p.Add(new Person { Name = "Ira", Address = "H801", Age = 25 });
				p.Add(new Person { Name = "Jennifer", Address = "I1704", Age = 33 });

				PersonImplementation pi = new PersonImplementation();
				Console.WriteLine(pi.GetName(p));
				Console.WriteLine(pi.Average(p));

			}
			catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
		}
	}

}
