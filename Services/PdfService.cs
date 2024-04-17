
using iTextSharp.text;
using iTextSharp.text.html.simpleparser;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Abstractions;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using PuppeteerSharp;
using PuppeteerSharp.Media;
using System.IO;

public class PdfService : IPdfService
{
    private readonly IWebHostEnvironment _webHostEnvironment;
    private readonly IRazorViewEngine _razorViewEngine;
    private readonly ITempDataProvider _tempDataProvider;
    private readonly IServiceProvider _serviceProvider;

    public PdfService(IWebHostEnvironment webHostEnvironment, IRazorViewEngine razorViewEngine, ITempDataProvider tempDataProvider, IServiceProvider serviceProvider)
    {
        _webHostEnvironment = webHostEnvironment;
        _razorViewEngine = razorViewEngine;
        _tempDataProvider = tempDataProvider;
        _serviceProvider = serviceProvider;
    }

    public async Task<byte[]> GeneratePdfAsync(GeneratePdfRequest request)
    {
        var viewName = "~/Views/PdfTemplate.cshtml"; // replace with your Razor view file
        var htmlData = await RenderViewAsync(viewName, request);
        var pdfData = await ConvertHtmlToPdf(htmlData);
        return pdfData;
    }

    private async Task<string> RenderViewAsync<TModel>(string viewName, TModel model)
    {
        using var requestLifetimeScope = _serviceProvider.CreateScope();
        var httpContext = new DefaultHttpContext { RequestServices = requestLifetimeScope.ServiceProvider };
        var actionContext = new ActionContext(httpContext, new RouteData(), new ActionDescriptor());

        using var output = new StringWriter();
        var viewResult = _razorViewEngine.GetView("", viewName, false);

        if (viewResult.View == null)
        {
            throw new ArgumentNullException($"{viewName} does not match any available view");
        }

        var viewDictionary = new ViewDataDictionary(new EmptyModelMetadataProvider(), new ModelStateDictionary())
        {
            Model = model
        };

        var viewContext = new ViewContext(actionContext, viewResult.View, viewDictionary, new TempDataDictionary(actionContext.HttpContext, _tempDataProvider), output, new HtmlHelperOptions());

        await viewResult.View.RenderAsync(viewContext);

        return output.ToString();
    }

    private async Task<byte[]> ConvertHtmlToPdf(string htmlData)
    {
        // download the browser executable
        // initial download may take up to 5 minutes
       var installedBrowser =await new BrowserFetcher().DownloadAsync(BrowserTag.Stable);
        // Modify the DefaultViewport options to match the dimensions of an A4 sheet
        var browserOptions = new LaunchOptions
        {
            Headless = true,
            Args = new[] { "--no-sandbox" },
            ExecutablePath= installedBrowser.GetExecutablePath(),
            //DefaultViewport = new ViewPortOptions
            //{
            //    Width = 595, // A4 width in points (1 point = 1/72 inch)
            //    Height = 842 // A4 height in points (1 point = 1/72 inch)
            //}
        };

        using var browser = await Puppeteer.LaunchAsync(browserOptions);
        using var page = await browser.NewPageAsync();

        await page.SetContentAsync(htmlData);

        var pdfOptions = new PdfOptions
        {
            Format = PaperFormat.A4,
            PrintBackground = true,
            DisplayHeaderFooter = false,

        };

        var pdfData = await page.PdfDataAsync(pdfOptions);

        return pdfData;
    }
}

