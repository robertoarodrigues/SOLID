namespace SOLID.ISP.ISP.Violation;
public class Customer : IRegister
{
    public void ValidateData()
    {
        //Validate CPF, Email
    }

    public void SaveBank()
    {
        //Insert in Customer table
    }

    public void SendEmail()
    {
        //Send email to customer
    }
}
