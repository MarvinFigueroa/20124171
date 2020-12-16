using System.Threading.Tasks;
using DogKeepers.Server.Entities;
using DogKeepers.Shared.QueryFilters;

namespace DogKeepers.Server.Interfaces.Repositories
{
    public interface IUserRepository
    {
        Task<User> GetByEmailPassword(SingInQueryFilter user);
    }
}