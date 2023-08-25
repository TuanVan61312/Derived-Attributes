using System;
using System.Collections.Generic;
using System.Text;

namespace Delivered
{
    internal class Address
    {
		private int number;

		public int Number
		{
			get { return number; }
			set { number = value; }
		}
		private string district;

		public string District
		{
			get { return district; }
			set { district = value; }
		}
		private string city;

		public string City
		{
			get { return city; }
			set { city = value; }
		}
		public Address(int number, string district, string city) 
		{
			Number = number;
            District = district;
			City = city;
		}
	}
}
