using Microsoft.AspNetCore.Mvc;

namespace Problemas.Controllers
{
    [ApiController]
    [Route("api/Problemas")]
    public class ProblemasController
    {
        [HttpGet]
        public int Get()
        {
            return 3;
        }
    }
}
