using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using MusicOrganizer.Models;

namespace MusicOrganizer.Controllers
{
  public class ArtistController : Controller
  {
    [HttpGet("/artist")]
    public ActionResult Index()
    {
      List<Artist> allArtists = Artist.GetAll();
      return View(allArtists);
    }
      [HttpPost("/artist")]
    public ActionResult Create(string artistName)
    {
      Artist theArtist = new Artist(artistName);
      return RedirectToAction("Index");
    }
    [HttpGet("/artist/{id}")]
    public ActionResult Show(int id)
    {
      Artist foundArtist = Artist.Find(id);
      return View(foundArtist);
    }
  }
}