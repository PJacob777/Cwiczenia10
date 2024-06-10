using Cwiczenia10.Model;

namespace Cwiczenia10.Response;

public class AccountResponse
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string? Phone { get; set; }
    public string Role { get; set; }
    public List<ResponseCard> ResponseCards { get; set; }
}

public class ResponseCard
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public int Amount { get; set; }
}