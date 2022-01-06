using BumbleDataAccess.DbAccess;
using BumbleDataAccess.Models;

namespace BumbleDataAccess.Data;

public class GoatData : IGoatData
{
    private readonly ISqlDataAccess _db;
    public GoatData(ISqlDataAccess db)
    {
        _db = db;
    }

    public Task<IEnumerable<GoatModel>> GetGoats() =>
        _db.LoadData<GoatModel, dynamic>("GetGoats", new { });

    public async Task<GoatModel?> GetGoat(int id)
    {
        var result = await _db.LoadData<GoatModel, dynamic>("GetGoat", new { Id = id });
        return result.FirstOrDefault();
    }

    public Task InsertGoat(GoatModel goat) =>
        _db.SaveData("InsertGoat", new { goat });
}
