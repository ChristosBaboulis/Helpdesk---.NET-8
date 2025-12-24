using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repositories
{
	public interface IActionRepository
	{
		Action? FindById(string Id);
		List<Action> GetAllActions();

		List<Action> FindByTitle(string title);
		List<Action> FindByDescription(string description);
		List<Action> FindBySubmissionDate(DateTime submissionDate);
	}
}
