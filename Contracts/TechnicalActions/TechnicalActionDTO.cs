using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.TechnicalActions
{
	public class TechnicalActionDTO
	{
		public string Title { get; set; }
		public string Description { get; set; }
		public DateTime SubmissionDate { get; set; }
		public TechnicalActionDTO(string title, string description, DateTime submissionDate)
		{
			Title = title;
			Description = description;
			SubmissionDate = submissionDate;
		}
	}
}
