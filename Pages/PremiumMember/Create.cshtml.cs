using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using PlataformaDeMembros.Data;
using PlataformaDeMembros.Models;

namespace PlataformaDeMembros.Pages_PremiumMember
{
    public class CreateModel : PageModel
    {
        private readonly PlataformaDeMembros.Data.ApplicationDbContext _context;

        public CreateModel(PlataformaDeMembros.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["MemberId"] = new SelectList(_context.Members, "Id", "Email");
            return Page();
        }

        [BindProperty]
        public PremiumMembers PremiumMembers { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.PremiumMember == null || PremiumMembers == null)
            {
                return Page();
            }

            _context.PremiumMember.Add(PremiumMembers);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
