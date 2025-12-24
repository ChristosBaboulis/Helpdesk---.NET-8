using Application.Repositories;
using Domain;
using Domain.Contacts.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Repositories
{
	public class RequestRepository : IRequestRepository
	{
		public List<Request> FindByActionId(string actionId)
		{
			throw new NotImplementedException();
		}

		public List<Request> FindByCategoryId(string categoryId)
		{
			throw new NotImplementedException();
		}

		public List<Request> FindByCloseDate(DateTime closeDate)
		{
			throw new NotImplementedException();
		}

		public List<Request> FindByCustomerId(string customerId)
		{
			throw new NotImplementedException();
		}

		public List<Request> FindByCustomerSupportId(string customerSupportId)
		{
			throw new NotImplementedException();
		}

		public Request? FindById(string Id)
		{
			throw new NotImplementedException();
		}

		public List<Request> FindByProblemDescription(string problemDescription)
		{
			throw new NotImplementedException();
		}

		public List<Request> FindByStatus(Status status)
		{
			throw new NotImplementedException();
		}

		public List<Request> FindBySubmissionDate(DateTime submissionDate)
		{
			throw new NotImplementedException();
		}

		public List<Request> FindByTechnicianId(string technicianId)
		{
			throw new NotImplementedException();
		}

		public List<Request> FindByTelephoneNumber(string telephoneNumber)
		{
			throw new NotImplementedException();
		}

		public List<Request> GetAllRequests()
		{
			throw new NotImplementedException();
		}
	}
}
