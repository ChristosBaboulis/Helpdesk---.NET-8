using Application.Repositories;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Repositories
{
	public class SpecialtyRepository : ISpecialtyRepository
	{
		Specialty? ISpecialtyRepository.FindById(string Id)
		{
			throw new NotImplementedException();
		}

		List<Specialty> ISpecialtyRepository.FindByType(string type)
		{
			throw new NotImplementedException();
		}

		List<Specialty> ISpecialtyRepository.GetAllSpecialties()
		{
			throw new NotImplementedException();
		}
	}
}
