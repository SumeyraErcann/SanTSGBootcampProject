using BootcampProje.Data.Repositories.Interface;
using BootcampProje.Domain.Users;
using System.Collections.Generic;
using System.Linq;

namespace BootcampProje.Data.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(UserDbContext context) : base(context)
        {
        }

        //user ıd ile get all ın içindeki parameteri birbiri ile eşitleyip listeliyor.
        public List<User> GetAll(int userId)
        {
            return _context.Users.Where(x => x.Id == userId)
                .ToList();
        }
    }
}
