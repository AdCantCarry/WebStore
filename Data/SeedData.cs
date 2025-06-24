using Microsoft.EntityFrameworkCore;
using WebStore.Models;

namespace WebStore.Data
{
    public static class SeedData
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().HasData(
                new Role { Id = 1, Name = "Admin" },
                new Role { Id = 2, Name = "Customer" }
            );

            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    FullName = "Admin User",
                    Email = "admin@webstore.com",
                    Password = "123456", // Chưa mã hóa
                    RoleId = 1,
                    Address = "123 Admin Street"
                }
            );

            modelBuilder.Entity<Brand>().HasData(
                new Brand { Id = 1, Name = "Apple" },
                new Brand { Id = 2, Name = "Samsung" },
                new Brand { Id = 3, Name = "Dell" }
            );

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Laptop" },
                new Category { Id = 2, Name = "Phone" },
                new Category { Id = 3, Name = "Tablet" }
            );

            modelBuilder.Entity<PaymentMethod>().HasData(
                 new PaymentMethod { Id = 1, MethodName = "COD" },
                 new PaymentMethod { Id = 2, MethodName = "PayPal" }
             );
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "iPhone 14",
                    Description = "Latest Apple phone",
                    Price = 999,
                    CategoryId = 2,
                    BrandId = 1
                },
                new Product
                {
                    Id = 2,
                    Name = "Galaxy S22",
                    Description = "Samsung flagship phone",
                    Price = 899,
                    CategoryId = 2,
                    BrandId = 2
                }
            );

            modelBuilder.Entity<ProductImage>().HasData(
                new ProductImage
                {
                    Id = 1,
                    ProductId = 1,
                    ImageUrl = "https://example.com/iphone14.jpg"
                    // TODO: Replace with local path when images are available
                },
                new ProductImage
                {
                    Id = 2,
                    ProductId = 2,
                    ImageUrl = "https://example.com/galaxys22.jpg"
                }
            );
            // Seed Order
            modelBuilder.Entity<Order>().HasData(
                new Order
                {
                    Id = 1,
                    UserId = 1,
                    PaymentMethodId = 1,
                    OrderDate = new DateTime(2024, 06, 01, 10, 0, 0), 
                    TotalAmount = 999,
                    Status = "Processing",
                    DeliveryAddress = "123 Admin Street"
                }
            );


            // Seed OrderDetail
            modelBuilder.Entity<OrderDetail>().HasData(
                new OrderDetail
                {
                    Id = 1,
                    OrderId = 1,
                    ProductId = 1,
                    Quantity = 1,
                    UnitPrice = 999
                }
            );

            // Seed CartItem
            modelBuilder.Entity<CartItem>().HasData(
                new CartItem
                {
                    Id = 1,
                    UserId = 1,
                    ProductId = 2,
                    Quantity = 1
                }
            );
            // Seed Feedback
            modelBuilder.Entity<Feedback>().HasData(
    new Feedback
    {
        Id = 1,
        UserId = 1,
        Message = "Sản phẩm rất tuyệt!",
        CreatedAt = new DateTime(2024, 06, 01)
    }
);
        }
    }
}
