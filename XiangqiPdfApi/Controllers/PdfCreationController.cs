using Microsoft.AspNetCore.Mvc;
using QuestPDF.Fluent;
using XiangqiPdfCreationApi.Model;
using XiangqiPdfCreationApi.Model.PdfComponents;
using XiangqiPdfCreationApi.Models;

namespace XiangqiPdfCreationApi.Controllers;

[ApiController]
[Route("api/pdfCreation")]
public class PdfCreationController : ControllerBase
{
    [HttpPost("/fromGameObject")]
	public IActionResult CreatePdfFromGameObject(GameObject? gameObject)
	{
		try
		{
			var parsedGameObject = gameObject ??= GameObjectTemplate.GenerateGameObjectTemplate();

			var document = new XiangqiPdfDocument(parsedGameObject);

			byte[] pdfBytes = document.GeneratePdf();

			return File(pdfBytes, "application/octet-stream");
		}
		catch (Exception ex)
		{
			return StatusCode(500);
		}
	}

	//[HttpPost("/fromPgnFile")]
	//public IActionResult CreatePdfFromPgn(GameObject? gameObject)
	//{
	//	try
	//	{
	//		var parsedGameObject = gameObject ??= GameObjectTemplate.GenerateGameObjectTemplate();

	//		var document = new XiangqiPdfDocument(parsedGameObject);

	//		byte[] pdfBytes = document.GeneratePdf();

	//		return File(pdfBytes, "application/octet-stream");
	//	}
	//	catch (Exception ex)
	//	{
	//		return StatusCode(500);
	//	}
	//}
}
