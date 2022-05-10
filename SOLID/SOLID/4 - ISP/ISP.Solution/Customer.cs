using SOLID.ISP.ISP.Solution.Interfaces;

namespace SOLID.ISP.ISP.Solution;
public class Customer : ICustomerRegistration
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
