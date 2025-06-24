public class PaymentMethod
{
    public int Id { get; set; }

    public required string MethodName { get; set; } // Cash, PayPal, Momo, VNPay...

    public ICollection<Order> Orders { get; set; } = new List<Order>();
}
