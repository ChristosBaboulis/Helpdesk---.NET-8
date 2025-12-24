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
	public class CustomerSupportRepository : ICustomerSupportRepository
	{
		List<CustomerSupport> ICustomerSupportRepository.FindByAddress(Address address)
		{
			throw new NotImplementedException();
		}

		List<CustomerSupport> ICustomerSupportRepository.FindByBirthdate(DateOnly birthdate)
		{
			throw new NotImplementedException();
		}

		List<CustomerSupport> ICustomerSupportRepository.FindByEmail(string email)
		{
			throw new NotImplementedException();
		}

		List<CustomerSupport> ICustomerSupportRepository.FindByEmployeeCode(string employeeCode)
		{
			throw new NotImplementedException();
		}

		CustomerSupport? ICustomerSupportRepository.FindById(string Id)
		{
			throw new NotImplementedException();
		}

		List<CustomerSupport> ICustomerSupportRepository.FindByLastName(string lastName)
		{
			throw new NotImplementedException();
		}

		List<CustomerSupport> ICustomerSupportRepository.FindByTelephoneNumber(string telephoneNumber)
		{
			throw new NotImplementedException();
		}

		List<CustomerSupport> ICustomerSupportRepository.GetAllCustomerSupportAgents()
		{
			throw new NotImplementedException();
		}
	}
}
