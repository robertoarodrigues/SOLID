using System.Data;
using System.Data.SqlClient;
using System.Net.Mail;

namespace SOLID.SRP.SRP.Violation;
public class Customer
{
    public Customer(int id, string name, string email, string cpf, DateTime createdAt)
    {
        Id = id;
        Name = name;
        Email = email;
        CPF = cpf;
        CreatedAt = createdAt;
    }

    public int Id { get; private set; }
    public string Name { get; private set; }
    public string Email { get; private set; }
    public string CPF { get; private set; }
    public DateTime CreatedAt { get; private set; }

    public string AddCustomer()
    {
        if (!Email.Contains("@"))
            return "Customer with e-mail invalid";

        if (CPF.Length != 11)
            return "Customer with CPF invalid";

        using (var cn = new SqlConnection())
        {
            var cmd = new SqlCommand();

            cn.ConnectionString = "MyConnectionString";
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO CLIENTE (Name, EMAIL CPF, CreatedAt) VALUES (@name, @email, @cpf, @createdAt))";

            cmd.Parameters.AddWithValue("name", Name);
            cmd.Parameters.AddWithValue("email", Email);
            cmd.Parameters.AddWithValue("cpf", CPF);
            cmd.Parameters.AddWithValue("createdAt", CreatedAt);

            cn.Open();
            cmd.ExecuteNonQuery();
        }

        var mail = new MailMessage("company@company.com", Email);
        var client = new SmtpClient
        {
            Port = 25,
            DeliveryMethod = SmtpDeliveryMethod.Network,
            UseDefaultCredentials = false,
            Host = "smtp.google.com"
        };

        mail.Subject = "Welcome.";
        mail.Body = "Congratulations! you are registered.";
        client.Send(mail);

        return "Customer registered successfully!";
    }
}
