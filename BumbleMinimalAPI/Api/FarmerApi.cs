namespace BumbleMinimalAPI.Api;

public static class FarmerApi
{
    public static void ConfigureFarmerApi(this WebApplication app)
    {
        // endpoints here
        app.MapGet("/Farmers", GetFarmers);
        app.MapGet("/Farmers/{id}", GetFarmer);
    }

    private static async Task<IResult> GetFarmers(IFarmerData data)
    {
        try
        {
            return Results.Ok(await data.GetFarmers());
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> GetFarmer(string id, IFarmerData data)
    {
        try
        {
            var result = await data.GetFarmer(id);
            if (result == null) return Results.NotFound();
            return Results.Ok(result);
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }
}
