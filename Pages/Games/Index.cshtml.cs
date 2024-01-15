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
    public class IndexModel : PageModel
    {
        private readonly Ghiran_Andrei_Project.Data.Ghiran_Andrei_ProjectContext _context;

        public IndexModel(Ghiran_Andrei_Project.Data.Ghiran_Andrei_ProjectContext context)
        {
            _context = context;
        }


        public IList<Game> Game { get;set; } = default!;

        public async Task OnGetAsync()
        {
           
            if (_context.Game != null)
            {
                Game = await _context.Game
                    .Include(b=>b.Platform)
                    .Include(b=>b.Developer)
                .ToListAsync();
            }
        }
    }
}
