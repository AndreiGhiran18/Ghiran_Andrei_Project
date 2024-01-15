using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Ghiran_Andrei_Project.Data;
using Ghiran_Andrei_Project.Models;
using Ghiran_Andrei_Project.Models.ViewModels;

namespace Ghiran_Andrei_Project.Pages.Developers
{
    public class IndexModel : PageModel
    {
        private readonly Ghiran_Andrei_Project.Data.Ghiran_Andrei_ProjectContext _context;
        private Developer developer;

        public IndexModel(Ghiran_Andrei_Project.Data.Ghiran_Andrei_ProjectContext context)
        {
            _context = context;
        }

        public IList<Developer> Developer { get;set; } = default!;

        public DeveloperIndexData DeveloperData { get;set; }
        public int DeveloperID { get;set; }
        public int GameID { get;set; }

        public Ghiran_Andrei_ProjectContext Get_context()
        {
            return _context;
        }

        public async Task OnGetAsync(int ? id, int ? gameID)
        {
            DeveloperData = new DeveloperIndexData();
            DeveloperData.Developers = await _context.Developer
                .Include(i => i.Games)
                .OrderBy(i => i.DeveloperName) 
                .ToListAsync();
            if (id != null)
            {
                DeveloperID = id.Value;
                Developer developer = DeveloperData.Developers
                .Where(i => i.ID == id.Value).Single();
                DeveloperData.Games = developer.Games;
            }
        }
    }
}
