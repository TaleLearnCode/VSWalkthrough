using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			Dictionary<string, List<Person>> people = GetDictionary();
			PrintOutPeopleCategory(people, "Spy");

		}

		public static void List()
		{
			List<Person> people = new();
			people.Add(new Person()
			{
				FirstName = "Chad",
				LastName = "Green",
				Category = "Category1"
			});

			people.Add(new Person()
			{
				FirstName = "James",
				LastName = "Bond",
				Category = "Spy"
			});

			people.Add(new Person()
			{
				FirstName = "John",
				LastName = "Smith",
				Category = "Spy"
			});

			foreach (Person person in people)
			{
				Console.WriteLine($"{person.LastName}, {person.FirstName}");
			}

		}

		public static Dictionary<string, List<Person>> GetDictionary()
		{

			Dictionary<string, List<Person>> people = new();

			Person chad = new()
			{
				FirstName = "Chad",
				LastName = "Green",
				Category = "Category1"
			};

			Person james = new()
			{
				FirstName = "James",
				LastName = "Bond",
				Category = "Spy"
			};

			Person john = new()
			{
				FirstName = "John",
				LastName = "Smith",
				Category = "Spy"
			};

			if (!people.ContainsKey(chad.Category))
			{
				people.Add(chad.Category, new List<Person>() { chad });
			}
			else
			{
				people[chad.Category].Add(chad);
			}

			if (people.TryGetValue(james.Category, out List<Person> value))
			{
				value.Add(james);
			}
			else
			{
				people.Add(james.Category, new List<Person>() { james });
			}

			if (people.TryGetValue(john.Category, out List<Person> value1))
			{
				value1.Add(john);
			}
			else
			{
				people.Add(john.Category, new List<Person>() { john });
			}

			return people;

		}

		public static void PrintOutPeopleCategory(Dictionary<string, List<Person>> people, string category)
		{
			foreach (Person person in people[category])
			{
				Console.WriteLine($"{person.LastName}, {person.FirstName}");
			}
		}

	}
}