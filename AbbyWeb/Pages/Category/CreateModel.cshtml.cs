using AbbyWeb.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AbbyWeb.Pages.Category;

// [BindProperties]
public class CreateModel : PageModel
{
    private ApplicationDbContext _applicationDbContext;

    public CreateModel(ApplicationDbContext applicationDbContext)
    {
        _applicationDbContext = applicationDbContext;
    }

    // private IEnumerable<Model.Category> Categories { get; set; }
    [BindProperty]
    public Model.Category Category { get; set; }
    
    public async Task<IActionResult> OnPost()
    {
        if (ModelState.IsValid)
        {
            await _applicationDbContext.Category.AddAsync(Category);
            await _applicationDbContext.SaveChangesAsync();
            return RedirectToPage("Index");
        }

        return Page();
    }
}