using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorToPDF.Views.Shared.UI.PrintSatisfactionSelector
{
    public class _PrintSatisfactionSelectorPartialModel : PageModel
    {
        public string SatisfactionArea {  get; set; }
        public void OnGet()
        {
        }
    }
}
