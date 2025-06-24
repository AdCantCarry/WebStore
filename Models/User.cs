public class User
{
    public int Id { get; set; }

    public required string FullName { get; set; }
    public required string Email { get; set; }
    public required string Password { get; set; }

    public string? Address { get; set; }

    public int RoleId { get; set; }
    public Role Role { get; set; } = null!;

    public ICollection<Order> Orders { get; set; } = new List<Order>();
    public ICollection<CartItem> CartItems { get; set; } = new List<CartItem>();
}
