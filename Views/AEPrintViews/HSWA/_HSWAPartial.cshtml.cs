using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorToPDF.ViewModels;

namespace RazorToPDF.Views.AEPrintViews.HSWA
{
    public class _HSWAPartialModel : PageModel
    {
        public HSWAMockData hswaData { get; set; }
        public void OnGet()
        {
        }
    }
}
