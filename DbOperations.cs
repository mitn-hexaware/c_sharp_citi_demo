// DbOperations.cs (Implementation of IDbOperations)
public class DbOperations : IDbOperations
{
    private readonly string _connectionString;

    public DbOperations(string connectionString)
    {
        _connectionString = connectionString;
    }

    public void SaveApplication(CreditCardApplication application)
    {
        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            // Create and execute SQL command to insert application data
            // ...
        }
    }

    public List<CreditCard> GetCreditCards()
    {
        List<CreditCard> cards = new List<CreditCard>();
        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            // Create and execute SQL command to retrieve credit card data
            // ...
        }
        return cards;
    }

    public List<Transaction> GetTransactions()
    {
        List<Transaction> transactions = new List<Transaction>();
        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            // Create and execute SQL command to retrieve transaction data
            // ...
        }
        return transactions;
    }
}