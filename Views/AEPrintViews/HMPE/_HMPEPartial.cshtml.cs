using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorToPDF.ViewModels;

namespace RazorToPDF.Views.AEPrintViews.HMPE
{
    public class _HMPEPartialModel : PageModel
    {
        public HMPEMockData hmpeData { get; set; }
        public void OnGet()
        {
        }
    }
}
