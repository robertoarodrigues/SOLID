namespace SOLID.OCP.OCP.Solution;
public class DebitAccountSavings : DebitAccount
{
    public override string Debit(decimal value, string account)
    {
        //Validates Account Anniversary
        // Debit Current Account
        return FormatTransaction();
    }
}
