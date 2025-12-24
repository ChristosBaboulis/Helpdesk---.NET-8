using Domain.Contacts.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
	public class Request
	{
		public Guid Id { get; private set; }
		public string TelephoneNumber { get; set; }
		public string ProblemDescription { get; set; }
		public DateTime SubmissionDate { get; set; }
		public DateTime CloseDate { get; set; }
		public Status status { get; set; }
		public Category category { get; set; }
		public Customer customer { get; set; }
		public CustomerSupport customerSupport { get; set; }
		public Technician technician { get; set; }
		public HashSet<Action> Actions { get; set; }

		public Request(
			string telephoneNumber, 
			string problemDescription, 
			DateTime submissionDate, 
			DateTime closeDate, 
			Status status, 
			Category category, 
			Customer customer, 
			CustomerSupport customerSupport, 
			Technician technician, 
			HashSet<Action> actions
			)
		{
			TelephoneNumber = telephoneNumber;
			ProblemDescription = problemDescription;
			SubmissionDate = submissionDate;
			CloseDate = closeDate;
			this.status = status;
			this.category = category;
			this.customer = customer;
			this.customerSupport = customerSupport;
			this.technician = technician;
			Actions = actions;
		}

		public override string ToString()
		{
			return $"Request(Id: {Id}, TelephoneNumber: {TelephoneNumber}, ProblemDescription: {ProblemDescription}, SubmissionDate: {SubmissionDate}, CloseDate: {CloseDate}, Status: {status}, Category: {category}, Customer: {customer}, CustomerSupport: {customerSupport}, Technician: {technician}, Actions: [{string.Join(", ", Actions)}])";
		}
	}
}
