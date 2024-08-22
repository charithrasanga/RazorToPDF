using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorToPDF.Views.Shared.UI
{
    public class _PrintSubjectCardPartialModel : PageModel
    {
        public string SubjectName { get; set; }
        public string Rows { get; set; }
        public void OnGet()
        {
        }
    }
}
