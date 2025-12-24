using Domain;
using Domain.Contacts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repositories
{
	public interface ITechnicianRepository
	{
		Technician? FindById(string Id);
		List<Technician> GetAllTechnicians();

		List<Technician> FindByLastName(string lastName);
		List<Technician> FindByTechnicianCode(string technicianCode);

		List<Technician> FindByTelephoneNumber(string telephoneNumber);
		List<Technician> FindByEmail(string email);
		List<Technician> FindByBirthdate(DateOnly birthdate);
		List<Technician> FindByAddress(Address address);

		List<Technician> FindBySpecialty(int specialtyId);
		List<Technician> FindBySpecialtyType(string specialtyType);
	}
}
