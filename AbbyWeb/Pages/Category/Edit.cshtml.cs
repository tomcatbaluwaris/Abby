using AbbyWeb.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AbbyWeb.Pages.Category;

public class EditModel : PageModel
{
    private ApplicationDbContext _applicationDbContext;

    public Model.Category Category { get; set; }
    

    public EditModel(ApplicationDbContext applicationDbContext)
    {
        _applicationDbContext = applicationDbContext;
    }

    public void OnGet(int id)
    {
        Category = _applicationDbContext.Category.FirstOrDefault(item => item.Id == id);
    }
    
    public async Task<IActionResult> OnPost()
    {
        if (ModelState.IsValid)
        {
            _applicationDbContext.Category.Update(Category);
            await _applicationDbContext.SaveChangesAsync();
            return RedirectToPage("Index");
        }

        return Page();
    }
    
}