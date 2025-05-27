namespace E_shopSystem;

public class ShippingAddress
{
    public int Id { get; set; }
    public string City { get; set; }
    public string StreetAddress { get; set; }
    public string State { get; set; }
    public string Country { get; set; }
    public int PostalCode { get; set; }

    public int OrderId { get; set; }
    public Order Order { get; set; }


}
