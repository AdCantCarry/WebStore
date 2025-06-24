public class Product
{
    public int Id { get; set; }

    public required string Name { get; set; }
    public required string Description { get; set; }
    public required decimal Price { get; set; }

    public int Stock { get; set; }

    public int BrandId { get; set; }
    public Brand Brand { get; set; } = null!;

    public int CategoryId { get; set; }
    public Category Category { get; set; } = null!;

    public ICollection<ProductImage> Images { get; set; } = new List<ProductImage>();
    public ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
}
