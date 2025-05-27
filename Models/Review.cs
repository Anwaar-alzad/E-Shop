using System.ComponentModel.DataAnnotations;

namespace E_shopSystem;

public class Review
{
    public int Id { get; set; }
    [Range(1, 5)]
    public int Rating { get; set; } // Rating score
    public string Comment { get; set; }

    public int CustomerId { get; set; }
    public Customer Customer { get; set; }
    public int ProductId { get; set; }
    public Product Product { get; set; }
}
