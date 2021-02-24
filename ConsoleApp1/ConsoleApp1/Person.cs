using System;

namespace ConsoleApp1
{

	class Person
	{

		public string Id { get; set; } = Guid.NewGuid().ToString();

		public string FirstName { get; set; }

		public string LastName { get; set; }

		public string Category { get; set; }

	}


}