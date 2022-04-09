namespace BumbleMinimalAPI.Api;

public static class GoatGifApi
{
    public static void ConfigureGoatGifApi(this WebApplication app)
    {
        app.MapGet("/GoatGif", GetGoatGifs);
        app.MapGet("/GoatGif/{gifId}", GetGoatGif);
    }

    /// <summary>
    /// Returns all goat gifs
    /// </summary>
    /// <returns>List of Goat Gif objects</returns>
    private static async Task<IResult> GetGoatGifs(IGoatGifData data)
    {
        try
        {
            return Results.Ok(await data.GetGoatGifs());
        }
        catch (Exception e)
        {
            return Results.Problem(e.Message);
        }
    }

    private static async Task<IResult> GetGoatGif(int gifId, IGoatGifData data)
    {
        try
        {
            var result = await data.GetGoatGif(gifId);
            if (result is null) return Results.NotFound();
            return Results.Ok(result);
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }
}