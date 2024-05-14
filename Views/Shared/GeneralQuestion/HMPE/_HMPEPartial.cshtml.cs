using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorToPDF.ViewModels;

namespace RazorToPDF.Views.Shared.GeneralQuestion.HMPE
{
    public class _HMPEPartialModel : PageModel
    {
        public HMPEMockData hmpeGQData { get; set; }
        public void OnGet()
        {
        }
    }
}
