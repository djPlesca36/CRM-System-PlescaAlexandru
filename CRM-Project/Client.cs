namespace CRMProject
{
public class Client : Person
{
    public string Phone { get; set; }

    public Client(int id, string name, string email, string phone)
        : base(id, name, email)
    {
        Phone = phone;
    }

    public override string ToString()
    {
        return base.ToString() + $", Phone: {Phone}";
    }
}

}
