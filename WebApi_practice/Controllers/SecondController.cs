using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi_practice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SecondController : ControllerBase
    {
        [HttpGet("abc")]
        public async Task<ActionResult> AnyRandomMethod([FromBody] int status)
        {
            if (status == 404)
            {
                return BadRequest();
            }
            return Ok();
        }
    }
}
