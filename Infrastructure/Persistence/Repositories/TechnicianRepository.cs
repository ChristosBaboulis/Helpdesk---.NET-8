using Domain;
using Domain.Contacts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Repositories;

namespace Infrastructure.Persistence.Repositories
{
	public class TechnicianRepository : ITechnicianRepository
	{
		public List<Technician> FindByAddress(Address address)
		{
			throw new NotImplementedException();
		}

		public List<Technician> FindByBirthdate(DateOnly birthdate)
		{
			throw new NotImplementedException();
		}

		public List<Technician> FindByEmail(string email)
		{
			throw new NotImplementedException();
		}

		public Technician? FindById(string Id)
		{
			throw new NotImplementedException();
		}

		public List<Technician> FindByLastName(string lastName)
		{
			throw new NotImplementedException();
		}

		public List<Technician> FindBySpecialty(int specialtyId)
		{
			throw new NotImplementedException();
		}

		public List<Technician> FindBySpecialtyType(string specialtyType)
		{
			throw new NotImplementedException();
		}

		public List<Technician> FindByTechnicianCode(string technicianCode)
		{
			throw new NotImplementedException();
		}

		public List<Technician> FindByTelephoneNumber(string telephoneNumber)
		{
			throw new NotImplementedException();
		}

		public List<Technician> GetAllTechnicians()
		{
			throw new NotImplementedException();
		}
	}
}
