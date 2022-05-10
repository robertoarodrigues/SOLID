namespace SOLID.OCP.OCP.Solution;
public class DebitCurrentAccount : DebitAccount
{
    public override string Debit(decimal value, string account)
    {
        // Debit Current Account
        return FormatTransaction();
    }
}
