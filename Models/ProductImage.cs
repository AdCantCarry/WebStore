public class ProductImage
{
    public int Id { get; set; }

    public required string ImageUrl { get; set; }
    public bool IsMain { get; set; }

    public int ProductId { get; set; }
    public Product Product { get; set; } = null!;
}
