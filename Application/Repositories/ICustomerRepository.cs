using Domain;
using Domain.Contacts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repositories
{
	public interface ICustomerRepository
	{
		Customer? FindById(string Id);
		List<Customer> GetAllCustomers();
		
		List<Customer> FindByCustomerCode(string customerCode);

		List<Customer> FindByLastName(string lastName);
		List<Customer> FindByTelephoneNumber(string telephoneNumber);
		List<Customer> FindByEmail(string email);
		List<Customer> FindByBirthdate(DateOnly birthdate);
		List<Customer> FindByAddress(Address address);
	}
}
