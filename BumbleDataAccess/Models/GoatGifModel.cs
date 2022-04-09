using System.ComponentModel.DataAnnotations.Schema;

namespace BumbleDataAccess.Models;

[Table("goatGifs")]
public class GoatGifModel
{
    public int id { get; set; }
    public string gifName { get; set; }
    public string gifLink { get; set; }
    public string addedAt { get; set; }
    public ulong addedBy { get; set; }
}