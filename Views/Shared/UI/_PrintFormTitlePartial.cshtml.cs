using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorToPDF.Views.Shared.UI
{
    public class _PrintFormTitlePartialModel : PageModel
    {
        public int ParentCount { get; set; }
        public void OnGet()
        {
        }
    }
}
