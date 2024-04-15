using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;



namespace JWTToken.Controllers
{
    [Route("api/[controller]")]
    [ApiController, Authorize]
    public class HomeController : ControllerBase
    {
        private readonly IConfiguration configuration;

        public HomeController(
             IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        [HttpGet]
        [Route("GetResult")]
        public async Task<ActionResult<bool>> GetResult()
        {
            bool response = true;
            return Ok(response);
        }
    }
}
