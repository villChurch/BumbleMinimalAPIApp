using BumbleDataAccess.DbAccess;
using BumbleDataAccess.Models;

namespace BumbleDataAccess.Data;

public class GoatGifData : IGoatGifData
{
    private readonly ISqlDataAccess _db;

    public GoatGifData(ISqlDataAccess db)
    {
        _db = db;
    }

    public Task<IEnumerable<GoatGifModel>> GetGoatGifs() =>
        _db.LoadData<GoatGifModel, dynamic>("GetGoatGifs", new { });

    public async Task<GoatGifModel?> GetGoatGif(int gifId)
    {
        var result = await _db.LoadData<GoatGifModel, dynamic>("GetGoatGif", new { Id = gifId});
        return result.FirstOrDefault();
    }
}