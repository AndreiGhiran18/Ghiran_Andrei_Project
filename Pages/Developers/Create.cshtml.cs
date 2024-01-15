using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Ghiran_Andrei_Project.Data;
using Ghiran_Andrei_Project.Models;

namespace Ghiran_Andrei_Project.Pages.Developers
{
    public class CreateModel : PageModel
    {
        private readonly Ghiran_Andrei_Project.Data.Ghiran_Andrei_ProjectContext _context;

        public CreateModel(Ghiran_Andrei_Project.Data.Ghiran_Andrei_ProjectContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Developer Developer { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Developer == null || Developer == null)
            {
                return Page();
            }

            _context.Developer.Add(Developer);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
