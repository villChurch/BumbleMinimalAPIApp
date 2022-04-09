using BumbleDataAccess.Models;

namespace BumbleDataAccess.Data;

public interface IGoatGifData
{
    public Task<IEnumerable<GoatGifModel>> GetGoatGifs();

    public Task<GoatGifModel?> GetGoatGif(int gifId);
}