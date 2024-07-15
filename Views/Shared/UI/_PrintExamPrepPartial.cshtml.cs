using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorToPDF.Views.Shared.UI
{
    public class _PrintExamPrepPartialModel : PageModel
    {
        public string ExamType { get; set; }
        public void OnGet()
        {
        }
    }
}
