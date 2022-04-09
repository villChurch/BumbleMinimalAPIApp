using BumbleDataAccess.Models;

namespace BumbleDataAccess.Data;

public interface ICookingDoesData
{
    public Task<IEnumerable<CookingDoesModel>> GetCDoes();

    public Task<CookingDoesModel?> GetCDoe(int id);
}