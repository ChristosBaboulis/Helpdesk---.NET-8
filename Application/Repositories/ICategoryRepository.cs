using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repositories
{
	public interface ICategoryRepository
	{
		Category? FindById(string Id);
		List<Category> GetAllCategories();

		List<Category> FindByType(string type);

		List<Category> FindBySpecialtyId(string specialtyId);
	}
}
