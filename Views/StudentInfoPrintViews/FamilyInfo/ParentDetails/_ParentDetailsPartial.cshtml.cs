using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorToPDF.Views.StudentInfoPrintViews.FamilyInfo.ParentDetails
{
    public class _ParentDetailsPartialModel : PageModel
    {
        public string ParentCount { get; set; }
        public void OnGet()
        {
        }
    }
}
