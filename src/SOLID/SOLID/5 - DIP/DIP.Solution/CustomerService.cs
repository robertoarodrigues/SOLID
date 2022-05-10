using SOLID.DIP.DIP.Solution.Interfaces;

namespace SOLID.DIP.DIP.Solution;
public class CustomerService : ICustomerService
{
    private readonly ICustomerRepository _customerRepository;
    private readonly IEmailService _emailServices;

    public CustomerService(
        IEmailService emailServices,
        ICustomerRepository customerRepository)
    {
        _emailServices = emailServices;
        _customerRepository = customerRepository;
    }

    public string AddCustomer(Customer customer)
    {
        if (!customer.Validate())
            return "Invalid data";

        _customerRepository.AddCustomer(customer);

        _emailServices.Send("company@company.com", customer.Email.Address, "Welcome", "Congratulations you are registered");

        return "Customer registered successfully";
    }
}
