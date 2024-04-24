using Microsoft.AspNetCore.Mvc;
using System.Net;

[ApiController]
[Route("[controller]")]
public class PdfController : ControllerBase
{
    private readonly PdfService _pdfService;

    public PdfController(PdfService pdfService)
    {
        _pdfService = pdfService;
    }

    [HttpPost("GeneratePDF")]
    [ProducesResponseType(typeof(FileContentResult), 200)]
    public async Task<IActionResult> GeneratePdf([FromBody] GeneratePdfRequest request)
    {
       
        var pdfData = await _pdfService.GeneratePdfAsync(request);
        var downloadFilename = "file_" + Path.ChangeExtension(Path.GetRandomFileName(), ".pdf");
        return new FileContentResult(pdfData, "application/pdf")
        {
            FileDownloadName = downloadFilename
        };
    }
}
