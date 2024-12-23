// ICreditScoreApi.cs (Interface for External API)
public interface ICreditScoreApi
{
    int GetCreditScore(string ssn);
}

// ICardIssuanceService.cs (Interface for Card Issuance Service)
public interface ICardIssuanceService
{
    void IssueCard(CreditCardApplication application);
}

// IDbOperations.cs (Interface for Database Operations)
public interface IDbOperations
{
    void SaveApplication(CreditCardApplication application);
    List<CreditCard> GetCreditCards();
    List<Transaction> GetTransactions();
    // Other database operations
}