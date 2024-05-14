using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorToPDF.ViewModels;

namespace RazorToPDF.Views.Shared.WritingSample
{
    public class _WritingSampleModel : PageModel
    {
        public WritingSampleMockData writingSampleData {  get; set; }
        public void OnGet()
        {
        }
    }
}
