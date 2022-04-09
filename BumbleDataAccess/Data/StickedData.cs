using BumbleDataAccess.DbAccess;
using BumbleDataAccess.Models;

namespace BumbleDataAccess.Data;

public class StickedData : IStickedData
{
    private readonly ISqlDataAccess _db;

    public StickedData(ISqlDataAccess db)
    {
        _db = db;
    }
    
    public Task<IEnumerable<StickedModel>> GetSticks() =>
        _db.LoadData<StickedModel, dynamic>("GetSticks", new { });

    public async Task<StickedModel?> GetStick(int id)
    {
        var result = await _db.LoadData<StickedModel, dynamic>("GetStick", new { Id = id });
        return result.FirstOrDefault();
    }
}