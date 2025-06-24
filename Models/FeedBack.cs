public class Feedback
{
    public int Id { get; set; }

    public int UserId { get; set; }
    public User User { get; set; } = null!;

    public required string Message { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.Now;
}
