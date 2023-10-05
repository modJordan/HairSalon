using Microsoft.EntityFrameworkCore;

namespace HairSalon.Models;

public class HairSalonContext : DbContext
{
  public DbSet<jordan_kennedy> jordan_kennedys { get; set; }

  public HairSalonContext (DbContextOptions options) : base(options) { }

}