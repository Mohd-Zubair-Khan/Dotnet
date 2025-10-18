using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class RegisterModel : PageModel
{
    [BindProperty] public string UserName { get; set; }
    [BindProperty] public string Email { get; set; }
    [BindProperty] public string Password { get; set; }

    public void OnPost()
    {
        // Add registration logic here
    }
}
