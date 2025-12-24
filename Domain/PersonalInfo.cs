using Domain.Contacts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
	public class PersonalInfo
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string TelephoneNumber { get; set; }
		public Email Email { get; set; }
		public DateOnly BirthDate { get; set; }
		public Address Address { get; set; }

		public PersonalInfo(string firstName, string lastName, string telephoneNumber, Email email, DateOnly birthDate, Address address)
		{
			FirstName = firstName;
			LastName = lastName;
			TelephoneNumber = telephoneNumber;
			Email = email;
			BirthDate = birthDate;
			Address = address;
		}

		public override string ToString()
		{
			return $"PersonalInfo(FirstName: {FirstName}, LastName: {LastName}, TelephoneNumber: {TelephoneNumber}, Email: {Email}, BirthDate: {BirthDate}, Address: {Address})";
		}
	}
}
