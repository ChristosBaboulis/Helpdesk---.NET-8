using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Repositories;

namespace Infrastructure.Persistence.Repositories
{
	public class UserRepository : IUserRepository
	{
		public User? FindByUsername(string username)
		{
			// Implementation to find a user by username
			return null;
		}
	}
}
