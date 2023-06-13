using Investments.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace Investments.Api.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class SharesController : ControllerBase
	{
		private readonly IFIFOStrategyService _fIFOStrategyService;
		private readonly ILogger<SharesController> _logger;

		public SharesController(ILogger<SharesController> logger,
			IFIFOStrategyService fIFOStrategyService)
		{
			_logger = logger;
			_fIFOStrategyService = fIFOStrategyService;
		}

		[HttpGet]
		public async Task<IActionResult> Get()
		{
			return Ok(await _fIFOStrategyService.GetCostBasisOfRemainingShares());
		}
	}
}