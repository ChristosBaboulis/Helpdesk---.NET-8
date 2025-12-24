using Domain;
using Domain.Contacts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repositories
{
	public interface ICustomerSupportRepository
	{
		CustomerSupport? FindById(string Id);
		List<CustomerSupport> GetAllCustomerSupportAgents();
		
		List<CustomerSupport> FindByEmployeeCode(string employeeCode);
		
		List<CustomerSupport> FindByLastName(string lastName);
		List<CustomerSupport> FindByTelephoneNumber(string telephoneNumber);
		List<CustomerSupport> FindByEmail(string email);
		List<CustomerSupport> FindByBirthdate(DateOnly birthdate);
		List<CustomerSupport> FindByAddress(Address address);
	}
}
