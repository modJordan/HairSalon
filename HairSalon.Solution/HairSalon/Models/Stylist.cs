using System.Collections.Generic;

namespace HairSalon.Models
{
  public class Stylist
  {
    public int StylistId { get; set; }
    public string Name { get; set; }
    public Specialty Specialty { get; set; }
    public List<Client> Clients { get; set; }
  }

  public enum Specialty
  {
    Haircut = 1,
    Color = 2,
    Perm = 3,
    Style = 4,
    CurlExpert = 5,
    Bridal = 6
  }
}