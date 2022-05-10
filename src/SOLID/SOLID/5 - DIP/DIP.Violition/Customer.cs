namespace SOLID.DIP.DIP.Violition;
public class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Email Email { get; set; }
    public Cpf Cpf { get; set; }
    public DateTime CreatedAt { get; set; }

    public bool Validate()
    {
        return Email.Validate() && Cpf.Validate();
    }
}
