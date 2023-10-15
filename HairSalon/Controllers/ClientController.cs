using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;


namespace HairSalon.Controllers
{
  public class ClientController : Controller
  {
    private readonly HairSalonContext _db;

    public ClientController(HairSalonContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Client> model = _db.Clients.ToList();
      return View(model);
    }
    public ActionResult Create()
    {
      ViewBag.StylistId = new SelectList(_db.Stylists, "StylistId", "Name");
      return View();
    }

    [HttpPost]
    public ActionResult Create(Client client)
    {
      _db.Clients.Add(client);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Client thisClient = _db.Clients.Include(c => c.Stylist).FirstOrDefault(client => client.ClientId == id);
      if (thisClient == null)
      {
        return NotFound();
      }
      return View(thisClient);
    }

    public ActionResult AddStylist(int clientId)
    {
      Client client = _db.Clients.FirstOrDefault(client => client.ClientId == clientId);
      ViewBag.StylistId = new SelectList(_db.Stylists, "StylistId", "Name");
      return View(client);
    }

    [HttpPost]
    public ActionResult AddStylist(Client client)
    {
      _db.Clients.Update(client);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}