using Cwiczenia10.Context;
using Cwiczenia10.DTO;
using Cwiczenia10.Response;
using Microsoft.EntityFrameworkCore;
namespace Cwiczenia10.Service;

public interface IMochDB
{
    Task<AccountResponse?> GetAccountById(int id);
    bool CreateAccount(ProductDTO product);
}
public class MochDB (DatabaseContext databaseContext) : IMochDB
{
    public async Task<AccountResponse?> GetAccountById(int id)
    {
        var response = await databaseContext.Accounts
            .Where(a => a.IdAccount == id)
            .Select(a => new AccountResponse
            {
                FirstName = a.FirstName,
                LastName = a.LastName,
                Email = a.Email,
                Phone = a.Phone,
                Role = a.Role.Name,
                ResponseCards = databaseContext.ShoppingCarts
                    .Where(sc => sc.IdAccount == id)
                    .Select(sc => new ResponseCard
                    {
                        ProductId = sc.IdProduct,
                        ProductName = sc.Product.Name,
                        Amount = sc.Amount
                    }).ToList()
            }).FirstOrDefaultAsync();

        if (response == null)
        {
            //throw new NotFound("Nie znaleziono konta o id " + id);
        }

        return response;
    }
    

    public bool CreateAccount(ProductDTO product)
    {
        
    }
}