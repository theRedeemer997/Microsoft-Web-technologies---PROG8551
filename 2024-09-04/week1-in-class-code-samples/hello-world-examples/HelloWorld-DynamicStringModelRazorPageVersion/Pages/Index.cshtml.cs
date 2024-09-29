using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HelloWorld_DynamicStringModelRazorPageVersion.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public string GreetingMessage { get; set; }

        public IndexModel()
        {
        }

        public void OnGet()
        {
            int hour = DateTime.Now.Hour;
            GreetingMessage = hour < 12 ? "Good morning" : "Good day";
        }
    }
}