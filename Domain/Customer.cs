using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
	public class Customer
	{
		public Guid Id { get; private set; }
		public string CustomerCode { get; set; }
		public PersonalInfo PersonalInfo { get; set; }

		public Customer(PersonalInfo personalInfo, string customerCode)
		{
			PersonalInfo = personalInfo;
			CustomerCode = customerCode;
		}

		public override string ToString()
		{
			return $"Customer(Id: {Id}, CustomerCode: {CustomerCode}, PersonalInfo: [FirstName: {PersonalInfo.FirstName}, LastName: {PersonalInfo.LastName}])";
		}
	}
}
