using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class ProductEntryModel : PageModel
{
    [BindProperty]
    public Product Product { get; set; }

    public void OnGet() { }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        // Save the product to your data store here

        TempData["Success"] = "Product added successfully!";
        return RedirectToPage(); // Refresh page
    }
}
