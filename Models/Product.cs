namespace E_shopSystem;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int Price { get; set; }

    public int CategoryId { get; set; }
    public Category Category { get; set; }

    public List<OrderItem> OrderItems { get; set; }
    public List<Review> Reviews { get; set; }
}
