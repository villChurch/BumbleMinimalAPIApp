using System.ComponentModel.DataAnnotations.Schema;

namespace BumbleDataAccess.Models;

[Table("sticked")]
public class StickedModel
{
    private int id { get; set; }
    public ulong recipientId { get; set; }
    public ulong stickerId { get; set; }
    public string messageLink { get; set; }
}