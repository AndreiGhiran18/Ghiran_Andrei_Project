using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Ghiran_Andrei_Project.Data;
using Ghiran_Andrei_Project.Models;

namespace Ghiran_Andrei_Project.Pages.Games
{
    public class DetailsModel : PageModel
    {
        private readonly Ghiran_Andrei_Project.Data.Ghiran_Andrei_ProjectContext _context;

        public DetailsModel(Ghiran_Andrei_Project.Data.Ghiran_Andrei_ProjectContext context)
        {
            _context = context;
        }

      public Game Game { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Game == null)
            {
                return NotFound();
            }

            var game = await _context.Game.FirstOrDefaultAsync(m => m.ID == id);
            if (game == null)
            {
                return NotFound();
            }
            else 
            {
                Game = game;
            }
            return Page();
        }
    }
}
