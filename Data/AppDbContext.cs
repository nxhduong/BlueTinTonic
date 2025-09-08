using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BlueTinTonic.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : IdentityDbContext<Member>(options)
{
    public DbSet<Entry> Entries { get; set; }
}
