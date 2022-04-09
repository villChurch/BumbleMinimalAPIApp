namespace BumbleMinimalAPI.Api;

public static class StickedApi
{
    public static void ConfigureStickApi(this WebApplication app)
    {
        app.MapGet("/Sticked", GetSticks);
        app.MapGet("/Sticked/{id}", GetStick);
    }

    private static async Task<IResult> GetSticks(IStickedData data)
    {
        try
        {
            return Results.Ok(await data.GetSticks());
        }
        catch (Exception e)
        {
            return Results.Problem(e.Message);
        }
    }

    private static async Task<IResult> GetStick(int id, IStickedData data)
    {
        try
        {
            var result = await data.GetStick(id);
            if (result is null) return Results.NotFound();
            return Results.Ok(result);
        }
        catch (Exception e)
        {
            return Results.Problem(e.Message);
        }
    }
}