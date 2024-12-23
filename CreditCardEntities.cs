// CreditCard.cs (Database Entity)
public class CreditCard
{
    public int CardId { get; set; }
    public string CardNumber { get; set; }
    public string CardType { get; set; }
    public decimal Balance { get; set; }
    public DateTime LastPayDate { get; set; }
    public DateTime CardAnniversary { get; set; }
    public decimal AnnualSpend { get; set; }
}

// Transaction.cs (Database Entity)
public class Transaction
{
    public int TransactionId { get; set; }
    public int CardId { get; set; }
    public decimal Amount { get; set; }
    public DateTime TransactionDate { get; set; }
}
