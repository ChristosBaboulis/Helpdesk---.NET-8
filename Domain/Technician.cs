using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
	public class Technician : User
	{
		public string TechnicianCode { get; private set; }
		public HashSet<Specialty> Specialties { get; set; }

		public Technician(PersonalInfo personalInfo, string username, string passwordHash, string technicianCode, HashSet<Specialty> specialties) 
			: base(personalInfo, username, passwordHash)
		{
			TechnicianCode = technicianCode;
			Specialties = specialties;
		}

		public override string ToString()
		{
			return $"Technician(Id: {Id}, Username: {Username}, PersonalInfo: [FirstName: {PersonalInfo.FirstName}, LastName: {PersonalInfo.LastName}], TechnicianCode: {TechnicianCode}, Specialties: [{string.Join(", ", Specialties)}])";
		}
	}
}
