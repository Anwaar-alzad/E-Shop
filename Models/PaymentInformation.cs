namespace E_shopSystem;

public class PaymentInformation
{
    public int Id { get; set; }
    // public PaymentInformation paymentInformation { get; set; }
    public int CardNumber { get; set; }
    public DateOnly ExpirationDate { get; set; }
    public int CVV { get; set; }

    public int OrderId { get; set; }
    public Order Order { get; set; }


}
