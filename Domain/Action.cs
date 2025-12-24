using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
	public abstract class Action
	{
		protected Guid Id { get; private set; }
		protected string Title { get; set; }
		protected string Description { get; set; }
		protected DateTime SubmissionDate { get; set; }

		protected Action(string title, string description, DateTime submissionDate)
		{
			Title = title ?? throw new ArgumentNullException(nameof(title));
			Description = description ?? throw new ArgumentNullException(nameof(description));
			SubmissionDate = submissionDate;
		}

		public override string ToString()
		{
			return $"Action(Id: {Id}, Title: {Title}, Description: {Description}, SubmissionDate: {SubmissionDate})";
		}
	}
}
