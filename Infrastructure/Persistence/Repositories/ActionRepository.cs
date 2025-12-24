using Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Repositories
{
	public class ActionRepository : IActionRepository
	{
		public Action? FindById(string Id)
		{
			throw new NotImplementedException();
		}

		public List<Action> GetAllActions()
		{
			throw new NotImplementedException();
		}

		public List<Action> FindByTitle(string title)
		{
			throw new NotImplementedException();
		}

		public List<Action> FindByDescription(string description)
		{
			throw new NotImplementedException();
		}

		public List<Action> FindBySubmissionDate(DateTime submissionDate)
		{
			throw new NotImplementedException();
		}
	}
}
