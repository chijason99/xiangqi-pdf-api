using Microsoft.AspNetCore.Mvc;
using XiangqiPdf.Domain;

namespace XiangqiImageCreationApi.Controllers;

[ApiController]
[Route("api/image-creation")]
public class ImageCreationController : ControllerBase
{
	private const string _testFen = "rnbakab2/8r/1c2c1n2/p1p1p1p1p/9/6P2/P1P1P3P/1C2C1N2/9/RNBAKABR1 b - - 7 4";

	[HttpPost] 
	public IActionResult ValidateFen(string fen)
	{
		return new JsonResult( new { 
			splittedFen = FenValidator.Validate(fen) 
		});
	}
}
