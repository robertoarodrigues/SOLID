namespace SOLID.OCP.OCP.Solution;
public class DebitAccountInvestment : DebitAccount
{
    public override string Debit(decimal value, string account)
    {
        //Debit Investment Account
        //Exempt Fees
        return FormatTransaction();
    }
}

