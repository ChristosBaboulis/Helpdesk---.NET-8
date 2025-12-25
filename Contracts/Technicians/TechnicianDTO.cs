using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Technicians
{
	public class TechnicianDTO
	{
		public string Username { get; set; }
		public string PasswordHash { get; set; }
		public PersonalInfo PersonalInfo { get; set; }
		public string TechnicianCode { get; set; }
		public HashSet<Guid> SpecialtyIds { get; set; }

		public TechnicianDTO(string username, string passwordHash, PersonalInfo personalInfo, string technicianCode, HashSet<Guid> specialtyIds)
		{
			Username = username;
			PasswordHash = passwordHash;
			PersonalInfo = personalInfo;
			TechnicianCode = technicianCode;
			SpecialtyIds = specialtyIds;
		}
	}
}
