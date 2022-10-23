using AbbyWeb.Data;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AbbyWeb.Pages.Category;

public class IndexModel : PageModel
{
    private ApplicationDbContext _applicationDbContext;
    public List<Model.Category> Categories { get; set; }

    public IndexModel(ApplicationDbContext applicationDbContext)
    {
        _applicationDbContext = applicationDbContext;
    }
    
    public void OnGet()
    {
        var categories = _applicationDbContext.Category;
        Categories = categories.ToList();
        
    }
    
 
}