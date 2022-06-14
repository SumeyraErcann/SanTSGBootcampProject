using BootcampProje.Application.Interfaces;
using BootcampProje.Application.Models;
using BootcampProje.Data;
using BootcampProje.Domain.Users;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace BootcampProje.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;        
        private readonly ILogger<UserService> _logger;
        public UserService(IUnitOfWork unitOfWork, ILogger<UserService> logger)
        {
            _unitOfWork = unitOfWork;            
            _logger = logger;            

        }
        public async Task CreateUser(User user)
        {
            _unitOfWork.Users.Add(user);            
            _unitOfWork.Complete();
            _logger.LogInformation("Yeni kullanıcı eklendi, eklenilen kullanıcı {@user}", user);
        }
    }
}
