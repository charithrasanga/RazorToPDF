using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorToPDF.ViewModels;

namespace RazorToPDF.Views.Shared.GeneralQuestion.ConcludingConversation
{
    public class _ConcludingConversationPartialModel : PageModel
    {
        public ConcludingConversationMockdata concludingConversationGQData { get; set; }
        public void OnGet()
        {
        }
    }
}
