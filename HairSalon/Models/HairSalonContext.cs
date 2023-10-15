using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;


namespace HairSalon.Models;

public class HairSalonContext : DbContext
{
  public DbSet<Stylist> Stylists { get; set; }
  public DbSet<Client> Clients { get; set; }

  public HairSalonContext(DbContextOptions<HairSalonContext> options) : base(options) { }

}

