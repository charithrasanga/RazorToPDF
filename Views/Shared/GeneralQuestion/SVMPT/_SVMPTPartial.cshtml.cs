using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorToPDF.ViewModels;

namespace RazorToPDF.Views.Shared.GeneralQuestion.SVMPT
{
    public class _SVMPTPartialModel : PageModel
    {
        public SVMPTMockData svmptGQData { get; set; }
        public void OnGet()
        {
        }
    }
}
