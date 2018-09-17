using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AmCart.WebAPI.Controllers
{
    [Route("api/service")]
    [Authorize]
    public class ServiceController : Controller
    {
        public IActionResult Get()
        {
            return new JsonResult("Authorized");
        }
    }
}
