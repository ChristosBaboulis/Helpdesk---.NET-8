using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
	public abstract class User
	{
		protected Guid Id { get; private set; }
		protected PersonalInfo PersonalInfo { get; set; }
		protected string Username { get; set; }
		protected string PasswordHash { get; set; }

		protected User(PersonalInfo personalInfo, string username, string passwordHash)
		{
			Id = Guid.NewGuid();
			PersonalInfo = personalInfo ?? throw new ArgumentNullException(nameof(personalInfo));
			Username = username ?? throw new ArgumentNullException(nameof(username));
			PasswordHash = passwordHash ?? throw new ArgumentNullException(nameof(passwordHash));
		}

		public override string ToString()
		{
			return $"User(Id: {Id}, Username: {Username}, PersonalInfo: [FirstName: {PersonalInfo.FirstName}, LastName: {PersonalInfo.LastName}])";
		}
	}
}
