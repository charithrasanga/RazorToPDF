using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorToPDF.Views.Shared.UI
{
    public class _PrintCheckboxPartialModel : PageModel
    {
        public string LabelName { get; set; }

        public void OnGet()
        {
        }
    }
}
