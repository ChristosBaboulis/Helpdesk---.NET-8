using Domain.Contacts.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Requests
{
	public class RequestDTO
	{
		public string TelephoneNumber { get; set; }
		public string ProblemDescription { get; set; }
		public DateTime SubmissionDate { get; set; }
		public DateTime CloseDate { get; set; }
		public Status status { get; set; }
		public Guid CategoryId { get; set; }
		public Guid CustomerId { get; set; }
		public Guid CustomerSupportId { get; set; }
		public Guid TechnicianId { get; set; }
		public HashSet<Guid> ActionIds { get; set; }

		public RequestDTO(
			string telephoneNumber, 
			string problemDescription, 
			DateTime submissionDate, 
			DateTime closeDate, 
			Status status, 
			Guid categoryId, 
			Guid customerId, 
			Guid customerSupportId, 
			Guid technicianId, 
			HashSet<Guid> actionIds)
		{
			TelephoneNumber = telephoneNumber;
			ProblemDescription = problemDescription;
			SubmissionDate = submissionDate;
			CloseDate = closeDate;
			this.status = status;
			CategoryId = categoryId;
			CustomerId = customerId;
			CustomerSupportId = customerSupportId;
			TechnicianId = technicianId;
			ActionIds = actionIds;
		}
	}
}
