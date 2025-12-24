using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
	public class Category
	{
		public Guid Id { get; private set; }
		public string Type { get; set; }
		public Specialty Specialty { get; set; }

		public Category(string type, Specialty specialty)
		{
			Type = type;
			Specialty = specialty;
		}

		public override string ToString()
		{
			return $"Category(Id: {Id}, Type: {Type}, Specialty: {Specialty})";
		}
	}
}
