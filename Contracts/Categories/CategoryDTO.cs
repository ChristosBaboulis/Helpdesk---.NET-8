using Contracts.Specialties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Categories
{
	public class CategoryDTO
	{
		public string Type { get; set; }
		public SpecialtyDTO Specialty { get; set; }

		public CategoryDTO(string type, SpecialtyDTO specialty)
		{
			Type = type;
			Specialty = specialty;
		}
	}
}
