using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
	public class TechnicalAction : Action
	{
		public TechnicalAction(string title, string description, DateTime submissionDate)
			: base(title, description, submissionDate)
		{
		}

		public override string ToString()
		{
			return $"TechnicalAction: {base.ToString()}";
		}
	}
}
