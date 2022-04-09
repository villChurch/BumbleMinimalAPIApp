using BumbleDataAccess.Models;

namespace BumbleDataAccess.Data;

public interface IStickedData
{
    public Task<IEnumerable<StickedModel>> GetSticks();

    public Task<StickedModel?> GetStick(int id);
}