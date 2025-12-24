using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Contacts
{
	public class Address
	{
		public string Street { get; set; }
		public string Number { get; set; }
		public string City { get; set; }
		public string PostalCode { get; set; }
		public string Country { get; set; }

		public Address(string street, string number, string city, string postalCode, string country)
		{
			Street = street;
			Number = number;
			City = city;
			PostalCode = postalCode;
			Country = country;
		}

		public Address(Address address)
		{
			Street = address.Street;
			Number = address.Number;
			City = address.City;
			PostalCode = address.PostalCode;
			Country = address.Country;
		}

		public override string ToString()
		{
			return $"Address(Street: {Street}, Number: {Number}, City: {City}, PostalCode: {PostalCode}, Country: {Country})";
		}
	}
}
