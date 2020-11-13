using System.Collections.Generic;
using System.Threading.Tasks;
using DogKeepers.Server.Entities;

namespace DogKeepers.Server.Interfaces.Services
{
    public interface IDogService
    {
        
        Task<List<Dog>> GetList(int random);

    }
}