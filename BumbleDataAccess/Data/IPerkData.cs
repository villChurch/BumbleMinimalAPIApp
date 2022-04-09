using BumbleDataAccess.Models;

namespace BumbleDataAccess.Data;

public interface IPerkData
{
    Task<IEnumerable<PerkModel>> GetPerks();

    Task<PerkModel?> GetPerk(int perkId);
}