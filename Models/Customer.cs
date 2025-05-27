namespace E_shopSystem;

public class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Email { get; set; }
    public int ContactInfo { get; set; }
    public List<Order> Orders { get; set; }
    public List<Review> Reviews { get; set; }
}

