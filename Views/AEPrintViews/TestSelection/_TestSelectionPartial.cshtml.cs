using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorToPDF.ViewModels;

namespace RazorToPDF.Views.AEPrintViews.TestSelection
{
    public class _TestSelectionModel : PageModel
    {
        public TestSelectionMockdata testSelectionData { get; set; }
        public void OnGet()
        {
        }
    }
}
