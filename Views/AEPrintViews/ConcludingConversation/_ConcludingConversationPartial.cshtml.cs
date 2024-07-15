using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorToPDF.ViewModels;

namespace RazorToPDF.Views.AEPrintViews.ConcludingConversation
{
    public class _ConcludingConversationModel : PageModel
    {
        public ConcludingConversationMockdata concludingConversationData { get; set; }
        public void OnGet()
        {
        }
    }
}
