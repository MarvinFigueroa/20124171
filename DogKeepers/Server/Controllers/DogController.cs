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

        [HttpGet("GetList")]
        public async Task<IActionResult>  GetList(int random = 0)
        {
            var dogs =await dogService.GetList(random);
            return Ok(dogs);
        }

    }
}