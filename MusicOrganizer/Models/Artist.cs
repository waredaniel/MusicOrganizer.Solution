using System.Collections.Generic;

namespace MusicOrganizer.Models
{
  public class Artist
  {
    public string Description { get; set; }

    public Artist(string description)
    {
      Description = description;
    }
  }
}
