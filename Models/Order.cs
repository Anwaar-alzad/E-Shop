namespace E_shopSystem;

public class Order
{
    public int Id { get; set; }
    public DateTime OrderDate { get; set; }
    public int TotalPrice { get; set; }
    public int CustomerId { get; set; }
    public Customer Customer { get; set; }

    public List<OrderItem> OrderItems { get; set; }
    public ShippingAddress ShippingAddress { get; set; }
    public PaymentInformation PaymentInformation { get; set; }
}
