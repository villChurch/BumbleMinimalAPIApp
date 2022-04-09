namespace BumbleMinimalAPI.Api;

public static class PerkApi
{
    public static void ConfigurePerkApi(this WebApplication app)
    {
        app.MapGet("/Perks", GetPerks);
        app.MapGet("/Perks/{id}", GetPerk);
    }

    private static async Task<IResult> GetPerks(IPerkData data)
    {
        try
        {
            return Results.Ok(await data.GetPerks());
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> GetPerk(int id, IPerkData data)
    {
        try
        {
            var result = await data.GetPerk(id);
            if (result is null) return Results.NotFound();
            return Results.Ok(result);
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }
}