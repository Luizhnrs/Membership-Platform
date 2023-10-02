using System.Runtime.InteropServices.ComTypes;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PlataformaDeMembros.Models;

namespace PlataformaDeMembros.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Member> Members { get; set; } = default!;
    public DbSet<PremiumMembers> PremiumMember { get; set; } = default!;

}
