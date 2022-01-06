namespace BumbleMinimalAPI.Api;

public static class DairyApi
{

    public static void ConfigureDairyApi(this WebApplication app)
    {
        // configure endpoints
        app.MapGet("/Dairy", GetDairies);
        app.MapGet("/Dairy/{id}", GetDairy);
    }

    private static async Task<IResult> GetDairies(IDairyData data)
    {
        try
        {
            return Results.Ok(await data.GetDairies());
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> GetDairy(string id, IDairyData data)
    {
        try
        {
            var result = await data.GetDairy(id);
            if (result == null) return Results.NotFound();
            return Results.Ok(result);
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }
}
