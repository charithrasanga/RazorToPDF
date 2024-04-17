using Microsoft.AspNetCore.Mvc;

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
    public async Task<FileContentResult> GeneratePdf([FromBody] GeneratePdfRequest request)
    {

        var pdfData = await _pdfService.GeneratePdfAsync(request);
        return File(pdfData, "application/pdf");
    }
}
