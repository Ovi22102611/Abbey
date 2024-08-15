using AbbeyWeb.Data;
using AbbeyWeb.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace
 AbbeyWeb.Pages.Categories
{
    [BindProperties]
    public class DeleteModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public Category Category
        {
            get;
            set;
        } = default!; // Initialize to avoid null reference

        public DeleteModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            if (id == 0) // Handle invalid ID
            {
                return NotFound();
            }

            Category = await _db.Category.FirstOrDefaultAsync(c => c.Id == id);

            if (Category == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var categoryFromDb = await _db.Category.FindAsync(Category.Id);

            if (categoryFromDb != null)
            {
                _db.Category.Remove(categoryFromDb);
                await _db.SaveChangesAsync();

            }

            return RedirectToPage("Index");

        }
    }
}