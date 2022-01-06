using BumbleDataAccess.Models;

namespace BumbleDataAccess.Data;

public interface IGoatData
{
    Task<GoatModel?> GetGoat(int id);
    Task<IEnumerable<GoatModel>> GetGoats();
    Task InsertGoat(GoatModel goat);
}