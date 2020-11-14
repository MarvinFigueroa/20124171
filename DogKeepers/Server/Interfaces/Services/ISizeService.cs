using System.Collections.Generic;
using System.Threading.Tasks;
using DogKeepers.Server.Entities;

namespace DogKeepers.Server.Interfaces.Services
{
    public interface ISizeService
    {
        Task<List<Size>> Get();
        
    } 
}