using AbbeyWeb.Data;
using AbbeyWeb.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AbbeyWeb.Pages.Categories
{
    public class EditModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public Category Category { get; set; }

        public EditModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet(int id)
        {
            Category = _db.Category.Find(id);
        }
        public async Task<IActionResult> OnPost(Category category) 
        {

            
            if (ModelState.IsValid) 
            {
                _db.Category.Update(category);
                await _db.SaveChangesAsync();
                return RedirectToPage("Index");


            }

            return Page();
           
        }    
    }
}
