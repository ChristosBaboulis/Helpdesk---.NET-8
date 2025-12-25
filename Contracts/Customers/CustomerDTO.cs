using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Customers
{
	public class CustomerDTO
	{
		public string CustomerCode { get; set; }
		public PersonalInfo PersonalInfo { get; set; }

		public CustomerDTO(string customerCode, PersonalInfo personalInfo)
		{
			CustomerCode = customerCode;
			PersonalInfo = personalInfo;
		}
	}
}
