using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorToPDF.ViewModels;

namespace RazorToPDF.Views.Shared.GeneralQuestion.HSWA
{
    public class _HSWAPartialModel : PageModel
    {
        public HSWAMockData hswaGQData { get; set; }
        public void OnGet()
        {
        }
    }
}
