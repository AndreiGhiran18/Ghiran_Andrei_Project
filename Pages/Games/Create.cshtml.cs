using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Ghiran_Andrei_Project.Data;
using Ghiran_Andrei_Project.Models;

namespace Ghiran_Andrei_Project.Pages.Games
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
            ViewData["PlatformID"] = new SelectList(_context.Set<Platform>(), "ID", "PlatformName");
            ViewData["DeveloperID"] = new SelectList(_context.Set<Developer>(), "ID", "DeveloperName");      return Page();
        }

        [BindProperty]
        public Game Game { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Game == null || Game == null)
            {
                return Page();
            }

            _context.Game.Add(Game);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
