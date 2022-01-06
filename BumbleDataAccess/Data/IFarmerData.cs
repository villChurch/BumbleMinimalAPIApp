using BumbleDataAccess.Models;

namespace BumbleDataAccess.Data;

public interface IFarmerData
{
    Task<FarmerModel?> GetFarmer(string id);
    Task<IEnumerable<FarmerModel>> GetFarmers();
    Task InsertFarmer(FarmerModel farmer);
}