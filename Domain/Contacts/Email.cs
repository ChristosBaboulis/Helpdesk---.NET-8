using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Contacts
{
	public class Email
	{
		public string EmailAddress { get; set; }
		
		public Email(string emailAddress)
		{
			if (string.IsNullOrWhiteSpace(emailAddress) || !emailAddress.Contains("@"))
			{
				throw new ArgumentException("Invalid email address.");
			}

			EmailAddress = emailAddress;
		}

		public override string ToString()
		{
			return EmailAddress;
		}
	}
}
