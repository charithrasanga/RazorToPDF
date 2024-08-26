using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorToPDF.ViewModels;

namespace RazorToPDF.Views.Shared.Boehm
{
    public class _BoehmPartialModel : PageModel
    {
        public BoehmMockdata boehmdata { get; set; }
        public void OnGet()
        {
        }
    }
}
