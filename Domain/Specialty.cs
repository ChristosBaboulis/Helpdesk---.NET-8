using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
	public class Specialty
	{
		public Guid Id { get; private set; }
		public string Type { get; set; }

		public Specialty(string type)
		{
			Type = type;
		}

		public override string ToString()
		{
			return $"Specialty(Id: {Id}, Type: {Type})";
		}
	}
}
