using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorToPDF.Views.Shared.UI
{
    public class _PrintNotMandatoryInputGroupPartialModel : PageModel
    {
        public string LabelName { get; set; }
        public string InputType { get; set; }
        public string InputPlaceHolder { get; set; }
        public string InputId { get; set; }
        public void OnGet()
        {
        }
    }
}
