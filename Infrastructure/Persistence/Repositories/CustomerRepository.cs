using Application.Repositories;
using Domain;
using Domain.Contacts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Repositories
{
	internal class CustomerRepository : ICustomerRepository
	{
		List<Customer> ICustomerRepository.FindByAddress(Address address)
		{
			throw new NotImplementedException();
		}

		List<Customer> ICustomerRepository.FindByBirthdate(DateOnly birthdate)
		{
			throw new NotImplementedException();
		}

		List<Customer> ICustomerRepository.FindByCustomerCode(string customerCode)
		{
			throw new NotImplementedException();
		}

		List<Customer> ICustomerRepository.FindByEmail(string email)
		{
			throw new NotImplementedException();
		}

		Customer? ICustomerRepository.FindById(string Id)
		{
			throw new NotImplementedException();
		}

		List<Customer> ICustomerRepository.FindByLastName(string lastName)
		{
			throw new NotImplementedException();
		}

		List<Customer> ICustomerRepository.FindByTelephoneNumber(string telephoneNumber)
		{
			throw new NotImplementedException();
		}

		List<Customer> ICustomerRepository.GetAllCustomers()
		{
			throw new NotImplementedException();
		}
	}
}
