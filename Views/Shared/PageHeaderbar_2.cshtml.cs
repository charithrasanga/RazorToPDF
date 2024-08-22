using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorToPDF.Views.Shared
{
    public class PageHeaderbar_2Model : PageModel
    {
        public string Title { get; set; }
        public string Name { get; set; }
        public void OnGet()
        {
        }
    }
}
