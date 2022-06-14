using BootcampProje.Domain.Users;
using System.Threading.Tasks;

namespace BootcampProje.Application.Interfaces
{
    public interface IUserService
    {
        Task CreateUser(User user);      
        
    }
}
