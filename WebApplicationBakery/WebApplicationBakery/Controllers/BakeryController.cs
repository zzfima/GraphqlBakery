using Microsoft.AspNetCore.Mvc;

namespace WebApplicationBakery.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class BakeryController : ControllerBase
	{
		List<Donut> donuts;

		private readonly ILogger<BakeryController> _logger;

		public BakeryController(ILogger<BakeryController> logger)
		{
			_logger = logger;
			donuts = new DonutsCollection().Donuts;
		}

		[HttpGet(Name = "GetDonuts")]
		public IEnumerable<Donut> Get() => donuts;

	}
}
