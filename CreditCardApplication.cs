// CreditCardApplication.cs (Business Logic)
public class CreditCardApplication
{
    public string ApplicantName { get; set; }
    public string SSN { get; set; }
    public string CardType { get; set; }
    public decimal AnnualIncome { get; set; }
    public int CreditScore { get; set; }
    public string ApplicationStatus { get; set; }
    public decimal CreditLimit { get; set; }

    public static bool IsApplicationApproved(CreditCardApplication application)
    {
        if (application.CreditScore < 500 || application.CreditScore > 850)
        {
            return false;
        }

        switch (application.CardType)
        {
            case "Diamond":
                return application.AnnualIncome >= 50000;
            case "Platinum":
                return application.AnnualIncome >= 100000;
            case "Premier":
                return application.AnnualIncome >= 120000;
            default:
                return false;
        }
    }

    public static decimal GetDefaultCreditLimit(string cardType)
    {
        switch (cardType)
        {
            case "Diamond":
                return 5000;
            case "Platinum":
                return 15000;
            case "Premier":
                return 25000;
            default:
                return 0;
        }
    }
}










