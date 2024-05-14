using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorToPDF.ViewModels;

namespace RazorToPDF.Views.Shared.HPA
{
    public class _HPAPartialModel : PageModel
    {
        public HPAMockData hpaData { get; set; }
        public void OnGet()
        {
        }
    }
}
