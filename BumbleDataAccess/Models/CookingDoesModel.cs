using System.ComponentModel.DataAnnotations.Schema;

namespace BumbleDataAccess.Models;

[Table("cookingdoes")]
public class CookingDoesModel
{
    [Column("id")]
    public int id { get; set; }
    
    [Column("goatId")]
    public int goatId { get; set; }
    
    [Column("dueDate")]
    public DateTime date { get; set; }
    
    [Column("ready")]
    public bool ready { get; set; }
}