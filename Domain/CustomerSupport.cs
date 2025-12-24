using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
	public class CustomerSupport : User
	{
		public string SupportCode { get; private set; }

		public CustomerSupport(PersonalInfo personalInfo, string username, string passwordHash, string supportCode) 
			: base(personalInfo, username, passwordHash)
		{
			SupportCode = supportCode;
		}

		public override string ToString()
		{
			return $"CustomerSupport(Id: {Id}, Username: {Username}, PersonalInfo: [FirstName: {PersonalInfo.FirstName}, LastName: {PersonalInfo.LastName}], SupportCode: {SupportCode})";
		}
	}
}
