using Cwiczenia10.DTO;
using Cwiczenia10.Service;

namespace Cwiczenia10.EndPoints;

public static class AddEndpoints
{
    public static void AddEnd(this WebApplication application)
    {
        application.MapGet("/api/accounts/{id:int}", async (int id, IMochDB mochDB) =>
        {
            var accountById = await mochDB.GetAccountById(id);
            if(accountById is null)
                return Results.NotFound(id);
            return Results.Ok(accountById);
        });

        application.MapPost("/api/products", async (ProductDTO productDTO, IMochDB mochDB) =>
        {
            bool account = await mochDB.CreateAccount(productDTO);
            if (!account)
                return Results.BadRequest();
            return Results.Created();
        });
    }
}