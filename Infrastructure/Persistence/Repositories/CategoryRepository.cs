using Application.Repositories;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Repositories
{
	public class CategoryRepository : ICategoryRepository
	{
		public Category? FindById(string Id)
		{
			throw new NotImplementedException();
		}

		public List<Category> GetAllCategories()
		{
			throw new NotImplementedException();
		}

		public List<Category> FindByType(string type)
		{
			throw new NotImplementedException();
		}

		public List<Category> FindBySpecialtyId(string specialtyId)
		{
			throw new NotImplementedException();
		}
	}
}
