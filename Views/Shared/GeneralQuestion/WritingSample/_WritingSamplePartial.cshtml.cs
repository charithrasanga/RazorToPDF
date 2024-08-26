using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorToPDF.ViewModels;

namespace RazorToPDF.Views.Shared.GeneralQuestion.WritingSample
{  
    public class _WritingSampleModel : PageModel
    {
        public WritingSampleMockData writingSampleGQData { get; set; }
        public void OnGet()
        {
        }
    }
}
