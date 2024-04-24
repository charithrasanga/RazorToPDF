
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
using Newtonsoft.Json;
using PuppeteerSharp;
using PuppeteerSharp.Media;
using System.IO;
using System.Text;

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


    public async Task<byte[]> ConvertHtmlToPdf(string htmlData)
    {
        // var functionAuthCode = "s_hsE0EBi1iCawYOL8tiRF6UKlpfnBUP3-ELY_XKc7jtAzFuolvbsQ==";
        var functionAuthCode = "iDjbHju3BAYuRbpgklMYPQ1JNgrTRlm5IEXF-YDtQgyMAzFukhgZEA==";
        using var httpClient = new HttpClient();

        var payload = new { htmlData = htmlData };
        var jsonPayload = JsonConvert.SerializeObject(payload);
        var content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");
       // var response = await httpClient.PostAsync("http://localhost:7101/api/GeneratePDF", content);
        var response = await httpClient.PostAsync($"https://puppeteerpdfgenerator.azurewebsites.net/api/GeneratePDF?code={functionAuthCode}", content);
        response.EnsureSuccessStatusCode();
        var pdfData = await response.Content.ReadAsByteArrayAsync();
        return pdfData;
    }
}

