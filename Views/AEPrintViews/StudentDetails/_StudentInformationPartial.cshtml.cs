using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorToPDF.ViewModels;

namespace RazorToPDF.Views.AEPrintViews.StudentDetails
{
    public class _StudentInformationPartialModel : PageModel
    {
        public IntialIntakeMockData intakeData { get; set; }
        public void OnGet()
        {
        }
    }


}
