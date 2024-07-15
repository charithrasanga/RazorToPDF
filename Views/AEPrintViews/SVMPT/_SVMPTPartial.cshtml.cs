using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorToPDF.ViewModels;

namespace RazorToPDF.Views.AEPrintViews.SVMPT
{
    public class _SVMPTPartialModel : PageModel
    {      
        public SVMPTMockData svmptData { get; set; }
        public void OnGet()
        {
        }
    }
}
