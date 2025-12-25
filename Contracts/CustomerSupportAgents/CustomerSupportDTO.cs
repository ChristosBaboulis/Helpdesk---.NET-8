using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.CustomerSupportAgents
{
	public class CustomerSupportDTO
	{
		public PersonalInfo PersonalInfo { get; set; }
		public string SupportCode { get; set; }
		public string Username { get; set; }
		public string PasswordHash { get; set; }

		public CustomerSupportDTO(PersonalInfo personalInfo, string supportCode, string username, string passwordHash)
		{
			PersonalInfo = personalInfo;
			SupportCode = supportCode;
			Username = username;
			PasswordHash = passwordHash;
		}
	}
}
