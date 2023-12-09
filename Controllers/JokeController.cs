using Dad_Joke_generator.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Dad_Joke_generator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JokeController : ControllerBase
    {
        // GET: api/<JokeController>
        [HttpGet]
        public async Task<DadJoke?> Get()
        {
            return await DadJokeFetcher.CmonDad();
        }

    }
}
