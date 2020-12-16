using System.Threading.Tasks;
using DogKeepers.Server.Entities;
using DogKeepers.Server.Exceptions;
using DogKeepers.Server.Interfaces.Repositories;
using DogKeepers.Server.Interfaces.Services;
using DogKeepers.Shared.QueryFilters;

namespace DogKeepers.Server.Services
{
    public class AuthService : IAuthService
    {

        private readonly IUserRepository userRepository;

        public AuthService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public async Task<User> Authenticate(SingInQueryFilter user)
        {
            var userData = await userRepository.GetByEmailPassword(user);

            if (userData == null)
            {
                throw new BusinessException("Los datos de acceso son incorrectos");
            }

            return userData;
        }
    }
}