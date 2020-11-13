using System.Collections.Generic;
using System.Threading.Tasks;
using DogKeepers.Server.Entities;
using DogKeepers.Server.Interfaces.Repositories;
using DogKeepers.Server.Interfaces.Services;

namespace DogKeepers.Server.Services
{
    public class DogService : IDogService
    {
        private readonly IDogRepository dogRepository;
        public DogService(IDogRepository dogRepository)
        {
            this.dogRepository = dogRepository;
        }
        public async Task<List<Dog>> GetList(int random)
        {
            var dogs = await dogRepository.GetList(random);

            return dogs;
        }
    }
}