using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorToPDF.ViewModels;

namespace RazorToPDF.Views.Shared.HSSS
{
    public class _HSSSPartialModel : PageModel
    {
        public HSSSMockdata hsssData {  get; set; }
        public void OnGet()
        {
        }
    }
}
