using BumbleDataAccess.Models;

namespace BumbleDataAccess.Data;

public interface IDairyData
{
    Task<IEnumerable<DairyModel>> GetDairies();
    Task<DairyModel?> GetDairy(string ownerId);
}