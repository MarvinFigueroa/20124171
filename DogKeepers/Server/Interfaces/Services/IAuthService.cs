using System.Threading.Tasks;
using DogKeepers.Server.Entities;
using DogKeepers.Shared.QueryFilters;

namespace DogKeepers.Server.Interfaces.Services
{
    public interface IAuthService
    {
        Task<User> Authenticate(SingInQueryFilter user);
    }
}