using BumbleDataAccess.DbAccess;
using BumbleDataAccess.Models;

namespace BumbleDataAccess.Data;

public class FarmerData : IFarmerData
{
    private readonly ISqlDataAccess _db;

    public FarmerData(ISqlDataAccess db)
    {
        _db = db;
    }

    public Task<IEnumerable<FarmerModel>> GetFarmers() =>
        _db.LoadData<FarmerModel, dynamic>("GetFarmers", new { });

    public async Task<FarmerModel?> GetFarmer(string id)
    {
        var result = await _db.LoadData<FarmerModel, dynamic>("GetFarmer", new { Id = id });
        return result.FirstOrDefault();
    }

    public Task InsertFarmer(FarmerModel farmer) =>
        _db.SaveData("InsertFarmer", new { farmer });
}
