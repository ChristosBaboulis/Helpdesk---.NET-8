using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Specialties
{
	public class SpecialtyDTO
	{
		public string Type { get; set; }
		public SpecialtyDTO(string type)
		{
			Type = type;
		}
	}
}
