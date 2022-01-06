namespace BumbleMinimalAPI.Api;

public static class GoatApi
{
    public static void ConfigureGoatApi(this WebApplication app)
    {
        app.MapGet("/Goats", GetGoats);
        app.MapGet("/Goats/{id}", GetGoat);
    }

    private static async Task<IResult> GetGoats(IGoatData data)
    {
        try
        {
            return Results.Ok(await data.GetGoats());
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> GetGoat(int id, IGoatData data)
    {
        try
        {
            var result = await data.GetGoat(id);
            if (result == null) return Results.NotFound();
            return Results.Ok(result);
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }  
    }
}
