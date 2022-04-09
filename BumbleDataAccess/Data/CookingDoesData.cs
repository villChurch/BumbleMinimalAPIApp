using BumbleDataAccess.DbAccess;
using BumbleDataAccess.Models;

namespace BumbleDataAccess.Data;

public class CookingDoesData : ICookingDoesData
{
    private readonly ISqlDataAccess _db;

    public CookingDoesData(ISqlDataAccess db)
    {
        _db = db;
    }

    public Task<IEnumerable<CookingDoesModel>> GetCDoes() =>
        _db.LoadData<CookingDoesModel, dynamic>("GetCDoes", new { });

    public async Task<CookingDoesModel?> GetCDoe(int goatId)
    {
        var result = await _db.LoadData<CookingDoesModel, dynamic>("GetCDoe", new { GoatId = goatId });
        return result.FirstOrDefault();
    }
}