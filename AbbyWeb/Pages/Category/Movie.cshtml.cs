using AbbyWeb.Data;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AbbyWeb.Pages.Category
{
    public class MovieModel : PageModel
    {
        private ApplicationDbContext _applicationDbContext;

        public MovieModel(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public Model.Category Category { get; set; }

        

        // public MovieModel(ApplicationDbContext applicationDbContext)
        // {
        //     _applicationDbContext = applicationDbContext;
        // }
        
       

      
        // public void OnGet(int Id)
        // {
        //     MovieProp = _applicationDbContext.Movies.FirstOrDefault(item => item.Id == Id);
        // }
        
        public void OnGet(int Id)
        {
            Category = _applicationDbContext.Category.FirstOrDefault(item => item.Id == Id);
        }

    }
}