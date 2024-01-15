using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Ghiran_Andrei_Project.Data;
using Ghiran_Andrei_Project.Models;

namespace Ghiran_Andrei_Project.Pages.Developers
{
    public class DeleteModel : PageModel
    {
        private readonly Ghiran_Andrei_Project.Data.Ghiran_Andrei_ProjectContext _context;

        public DeleteModel(Ghiran_Andrei_Project.Data.Ghiran_Andrei_ProjectContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Developer Developer { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Developer == null)
            {
                return NotFound();
            }

            var developer = await _context.Developer.FirstOrDefaultAsync(m => m.ID == id);

            if (developer == null)
            {
                return NotFound();
            }
            else 
            {
                Developer = developer;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Developer == null)
            {
                return NotFound();
            }
            var developer = await _context.Developer.FindAsync(id);

            if (developer != null)
            {
                Developer = developer;
                _context.Developer.Remove(Developer);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
