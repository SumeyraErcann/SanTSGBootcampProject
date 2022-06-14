using BootcampProje.Domain.Users;
using System.Collections.Generic;


namespace BootcampProje.Data.Repositories.Interface
{
    public interface IUserRepository :IRepository<User>
    {
        List<User> GetAll(int userId);
    }
}
