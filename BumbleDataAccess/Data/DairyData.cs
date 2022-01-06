using BumbleDataAccess.DbAccess;
using BumbleDataAccess.Models;

namespace BumbleDataAccess.Data;

public class DairyData : IDairyData
{
    private readonly ISqlDataAccess _db;

    public DairyData(ISqlDataAccess db)
    {
        _db = db;
    }

    public Task<IEnumerable<DairyModel>> GetDairies() =>
        _db.LoadData<DairyModel, dynamic>("GetDairies", new { });

    public async Task<DairyModel?> GetDairy(string ownerId)
    {
        var result = await _db.LoadData<DairyModel, dynamic>("GetDairy", new { Id = ownerId });
        return result.FirstOrDefault();
    }
}
