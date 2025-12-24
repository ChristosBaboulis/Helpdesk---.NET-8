using Domain;
using Domain.Contacts.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repositories
{
	public interface IRequestRepository
	{
		Request? FindById(string Id);
		List<Request> GetAllRequests();

		List<Request> FindByProblemDescription(string problemDescription);
		List<Request> FindBySubmissionDate(DateTime submissionDate);
		List<Request> FindByCloseDate(DateTime closeDate);
		List<Request> FindByStatus(Status status);
		List<Request> FindByTelephoneNumber(string telephoneNumber);

		List<Request> FindByCategoryId(string categoryId);
		List<Request> FindByCustomerId(string customerId);
		List<Request> FindByCustomerSupportId(string customerSupportId);
		List<Request> FindByTechnicianId(string technicianId);
		List<Request> FindByActionId(string actionId);
	}
}
