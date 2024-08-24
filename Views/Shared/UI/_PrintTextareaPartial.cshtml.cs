using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorToPDF.Views.Shared.UI
{
    public class _PrintTextareaPartialModel : PageModel
    {
        public int Rows { get; set; }
        public string InputPlaceholder { get; set; }

        public void OnGet()
        {
        }
    }
}
