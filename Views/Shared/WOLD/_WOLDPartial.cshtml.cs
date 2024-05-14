using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorToPDF.ViewModels;

namespace RazorToPDF.Views.Shared.WOLD
{
    public class _WOLDPartialModel : PageModel
    {
        public WOLDMockData woldData { get; set; }
        public void OnGet()
        {
        }
    }
}
