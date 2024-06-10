using Cwiczenia10.Service;

namespace Cwiczenia10.EndPoints;

public static class AddEndpoints
{
    public static void AddEnd(this WebApplication application)
    {
        application.MapGet("/api/accounts/{accountId:int}", async (int id, IMochDB mochDB) =>
        {
            var accountById = await mochDB.GetAccountById(id);
            if(accountById is null)
                return Results.NotFound(id);
            return Results.Ok(accountById);
        });
    }
}