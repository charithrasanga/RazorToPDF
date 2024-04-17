using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorToPDF.Views.Shared
{
    public class _PageHeaderBarModel : PageModel
    {
        public string Title { get; set; }
        public string Number { get; set; }

        public void OnGet()
        {
        }
    }
}
