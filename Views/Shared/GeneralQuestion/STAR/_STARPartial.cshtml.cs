using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorToPDF.ViewModels;

namespace RazorToPDF.Views.Shared.GeneralQuestion.STAR
{
    public class _STARPartialModel : PageModel
    {
        public STARMockData starGQData { get; set; }
        public void OnGet()
        {
        }
    }
}
