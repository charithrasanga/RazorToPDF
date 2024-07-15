using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorToPDF.ViewModels;

namespace RazorToPDF.Views.AEPrintViews.ReadingReadiness
{
    public class _ReadingReadinessModel : PageModel
    {
        public ReadingReadinessMockdata readingReadinessData { get; set; }
        public void OnGet()
        {
        }
    }
}
