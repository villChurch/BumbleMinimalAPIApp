using BumbleDataAccess.DbAccess;
using BumbleDataAccess.Models;

namespace BumbleDataAccess.Data;

public class PerkData : IPerkData
{
    private readonly ISqlDataAccess _db;

    public PerkData(ISqlDataAccess db)
    {
        _db = db;
    }

    public Task<IEnumerable<PerkModel>> GetPerks() =>
        _db.LoadData<PerkModel, dynamic>("GetPerks", new { });

    public async Task<PerkModel?> GetPerk(int perkId)
    {
        var result = await _db.LoadData<PerkModel, dynamic>("GetPerk", new { Id = perkId });
        return result.FirstOrDefault();
    }
}