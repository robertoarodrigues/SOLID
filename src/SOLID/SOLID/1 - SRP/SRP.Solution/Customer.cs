namespace SOLID.SRP.SRP.Solution;
public class Customer
{
    public int Id { get; private set; }
    public string Name { get; private set; }
    public Email Email { get; private set; }
    public Cpf CPF { get; private set; }
    public DateTime CreatedAt { get; private set; }

    public bool Validate()
    {
        return Email.Validate() && CPF.Validate();
    }
}
