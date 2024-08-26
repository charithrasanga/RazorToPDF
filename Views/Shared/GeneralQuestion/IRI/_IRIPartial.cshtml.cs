using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorToPDF.ViewModels;

namespace RazorToPDF.Views.Shared.GeneralQuestion.IRI
{
    public class _IRIPartialModel : PageModel
    {
        public IRIMockData iriGQData { get; set; }
        public void OnGet()
        {
        }
    }
}
