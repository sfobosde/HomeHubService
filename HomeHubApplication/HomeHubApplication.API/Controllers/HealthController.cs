using Microsoft.AspNetCore.Mvc;

namespace HomeHubApplication.API.Controllers
{
	[Route("health")]
	public class HealthController : Controller
	{
		[HttpGet]
		public IActionResult Index()
		{
			return Ok(new
			{
				status = "Healthy"
			});
		}
	}
}
