using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Ghiran_Andrei_Project.Data;
using Ghiran_Andrei_Project.Models;

namespace Ghiran_Andrei_Project.Pages.Platforms
{
    public class DetailsModel : PageModel
    {
        private readonly Ghiran_Andrei_Project.Data.Ghiran_Andrei_ProjectContext _context;

        public DetailsModel(Ghiran_Andrei_Project.Data.Ghiran_Andrei_ProjectContext context)
        {
            _context = context;
        }

      public Platform Platform { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Platform == null)
            {
                return NotFound();
            }

            var platform = await _context.Platform.FirstOrDefaultAsync(m => m.ID == id);
            if (platform == null)
            {
                return NotFound();
            }
            else 
            {
                Platform = platform;
            }
            return Page();
        }
    }
}
