namespace SOLID.DIP.DIP.Violition;
public class CustomerService
{
    public string AddCustomer(Customer customer)
    {
        if (!customer.Validate())
            return "Invalid data";

        var repo = new CustomerRepository();
        repo.AddCustomer(customer);

        EmailServices.Send("company@company.com", customer.Email.Address, "Welcome", "Congratulations you are registered");

        return "Customer registered successfully";
    }
}
