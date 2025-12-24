using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
	public class CommunicationAction : Action
	{
		public decimal CallDurationInMinutes { get; set; }

		public CommunicationAction(string title, string description, DateTime submissionDate, decimal callDurationInMinutes)
			: base(title, description, submissionDate)
		{
			CallDurationInMinutes = callDurationInMinutes;
		}

		public override string ToString()
		{
			return $"CommunicationAction: {base.ToString()}, CallDurationInMinutes: {CallDurationInMinutes}";
		}
	}
}
