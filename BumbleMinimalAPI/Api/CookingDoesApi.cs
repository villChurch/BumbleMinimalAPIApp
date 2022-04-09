namespace BumbleMinimalAPI.Api;

public static class CookingDoesApi
{
    public static void ConfigureCookingDoesApi(this WebApplication app)
    {
        app.MapGet("/CookingDoes", GetCookingDoes);
        app.MapGet("/CookingDoes/{goatId}", GetCookingDoe);
    }

    private static async Task<IResult> GetCookingDoes(ICookingDoesData data) 
    {
        try
        {
            return Results.Ok(await data.GetCDoes());
        }
        catch (Exception e)
        {
            return Results.Problem(e.Message);
        }
    }

    private static async Task<IResult> GetCookingDoe(int goatId, ICookingDoesData data)
    {
        try
        {
            var result = await data.GetCDoe(goatId);
            if (result is null) return Results.NotFound();
            return Results.Ok(result);
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }
}