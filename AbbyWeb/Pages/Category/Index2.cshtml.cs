using AbbyWeb.Data;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AbbyWeb.Pages.Category;

public class Index2 : PageModel
{
    private ApplicationDbContext _applicationDbContext;

    public Index2(ApplicationDbContext applicationDbContext)
    {
        _applicationDbContext = applicationDbContext;
    }

    public void OnGet()
    {
        var categories = _applicationDbContext.Category;
        Categories = categories.ToList();
    }

    public List<Model.Category> Categories { get; set; }
}