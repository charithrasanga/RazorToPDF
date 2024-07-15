using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorToPDF.ViewModels;

namespace RazorToPDF.Views.AEPrintViews.STAR
{
    public class _STARPartialModel : PageModel
    {
        public STARMockData starData { get; set; }
        public void OnGet()
        {
        }
    }
}
