using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PlataformaDeMembros.Data;
using PlataformaDeMembros.Models;

namespace PlataformaDeMembros.Pages_PremiumMember
{
    public class IndexModel : PageModel
    {
        private readonly PlataformaDeMembros.Data.ApplicationDbContext _context;

        public IndexModel(PlataformaDeMembros.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<PremiumMembers> PremiumMembers { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.PremiumMember != null)
            {
                PremiumMembers = await _context.PremiumMember
                .Include(p => p.Member).ToListAsync();
            }
        }
    }
}
