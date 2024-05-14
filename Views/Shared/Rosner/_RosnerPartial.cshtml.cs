using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorToPDF.ViewModels;

namespace RazorToPDF.Views.Shared.Rosner
{
    public class _RosnerPartialModel : PageModel
    {
        public RosnerMockdata rosnerData { get; set; }
        public void OnGet()
        {
        }
    }
}
