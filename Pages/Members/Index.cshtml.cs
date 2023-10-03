using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PlataformaDeMembros.Data;
using PlataformaDeMembros.Models;

namespace PlataformaDeMembros.Pages_Members
{
    public class IndexModel : PageModel
    {
        private readonly PlataformaDeMembros.Data.ApplicationDbContext _context;

        public IndexModel(PlataformaDeMembros.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Member> Member { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Members != null)
            {
                Member = await _context.Members.ToListAsync();
            }
        }
    }
}
