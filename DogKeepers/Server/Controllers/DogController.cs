using System.Threading.Tasks;
using DogKeepers.Server.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace DogKeepers.Server.Controllers
{

    [ApiController]
    [Route("api/[controller]")]

    public class DogController : ControllerBase
    {

        private readonly IDogService dogService;

        public DogController(IDogService dogService)
        {
            this.dogService = dogService;
        }

        [HttpGet]
        public async Task<IActionResult>  Get()
        {
            var dogs =await dogService.GetList();
            return Ok(dogs);
        }

    }
}