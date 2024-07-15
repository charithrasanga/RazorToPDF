using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorToPDF.ViewModels;

namespace RazorToPDF.Views.AEPrintViews.IRI
{
    public class IRIPartialModel : PageModel
    {
        public IRIMockData iriData { get; set; }
        public void OnGet()
        {
        }
    }
}
