using System;
using System.Collections.Generic;
using System.Text;

namespace Delivered
{
    internal class Person
    {
		//public string PRole { get; set; } = Role.WORKER;
		public Person Manager { get; set; }

		private string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}
		protected Address personAddress;

		public Address PersonAddress
        {
			get { return personAddress; }
			set { personAddress = value; }
		}
		protected DateTime birthdate;

		public DateTime Birthdate
		{
			get { return birthdate; }
			set 
			{ 
				birthdate = value;
                Age = DateTime.Now.Year - Birthdate.Year;
                if (Birthdate > DateTime.Now.AddYears(-Age))
                {
                    Age--;
                }
            }
		}
		private int age; //Delivered attributes

		public int Age
		{
			get { return age; }
			private set { age = value; }
		}
		private int ssn;

		public int SSN
		{
			get { return ssn; }
			private set { ssn = value; }
		}

		public Person(string name, Address personAddress, DateTime birthdate, int ssn) 
		{
			Name = name;
			PersonAddress = personAddress;
			Birthdate = birthdate;
			SSN = ssn;
			Age = DateTime.Now.Year - Birthdate.Year;
			if(Birthdate > DateTime.Now.AddYears(-Age)) 
			{
				Age--;
			}
		}
	}
}
