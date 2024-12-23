// StatementGenerator.cs (Batch Processing - Statement Generation)
public class StatementGenerator
{
    private readonly IDbOperations _dbOperations;

    public StatementGenerator(IDbOperations dbOperations)
    {
        _dbOperations = dbOperations;
    }

    public void GenerateMonthlyStatements()
    {
        // 1. Get credit card information and transactions from database
        List<CreditCard> cards = _dbOperations.GetCreditCards();
        List<Transaction> transactions = _dbOperations.GetTransactions();

        // 2. Generate statement for each card
        foreach (var card in cards)
        {
            // 2.1 Calculate annual charges
            decimal annualCharges = 0;
            if (card.CardType == "Platinum" && card.AnnualSpend < 20000)
            {
                annualCharges = 50;
            }
            else if (card.CardType == "Premier" && card.AnnualSpend < 40000)
            {
                annualCharges = 100;
            }

            // 2.2 Calculate interest
            decimal interest = 0;
            if (card.LastPayDate < DateTime.Now.AddDays(-30))
            {
                interest = (card.Balance * 0.20) / 12; // APR of 20%
            }

            // 2.3 Calculate late fees
            decimal lateFees = 0;
            if (card.LastPayDate < DateTime.Now.AddDays(-30))
            {
                if (card.Balance < 1000)
                {
                    lateFees = 2;
                }
                else if (card.Balance >= 1000 && card.Balance < 5000)
                {
                    lateFees = 4;
                }
                else
                {
                    lateFees = 8;
                }
            }

            // 2.4 Generate and save statement to database/file
            // ...
        }
    }
}