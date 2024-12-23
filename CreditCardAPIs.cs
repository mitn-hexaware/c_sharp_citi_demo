// CreditScoreApi.cs (Implementation of ICreditScoreApi)
public class CreditScoreApi : ICreditScoreApi
{
    public int GetCreditScore(string ssn)
    {
        // Implement logic to call external credit score API here
        // Example: Using HttpClient or a dedicated API client library
        // ...
    }
}

// CardIssuanceService.cs (Implementation of ICardIssuanceService)
public class CardIssuanceService : ICardIssuanceService
{
    public void IssueCard(CreditCardApplication application)
    {
        // Implement logic to call third-party card issuance service here
        // ...
    }
}