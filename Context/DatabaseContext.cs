using Cwiczenia10.Model;
using Microsoft.EntityFrameworkCore;

namespace Cwiczenia10.Context;

public class DatabaseContext : DbContext
{

    public DbSet<Product> Products { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<Account> Accounts { get; set; }
    public DbSet<ShoppingCard> ShoppingCarts { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<ProductCategory> ProductsCategories { get; set; }  
    protected DatabaseContext()
    {
    }

    public DatabaseContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
         base.OnModelCreating(modelBuilder);
         modelBuilder.Entity<ShoppingCard>()
            .HasKey(cart =>  new { cart.IdAccount, cart.IdProduct });
        
         modelBuilder.Entity<ProductCategory>()
             .HasKey(pc => new { pc.IdProduct, pc.IdCategory });
        
        // modelBuilder.Entity<Role>().HasData(new List<Role>()
        // {
        //     new()
        //     {
        //         IdRole = 1,
        //         Name = "Admin"
        //     },
        //     new()
        //     {
        //         IdRole = 2,
        //         Name = "User"
        //     },
        //     new()
        //     {
        //         IdRole = 3,
        //         Name = "Guest"
        //     }
        // });
        //
        // modelBuilder.Entity<Account>().HasData(new List<Account>()
        // {
        //     new()
        //     {
        //         IdAccount = 1,
        //         IdRole= 1,
        //         FirstName = "John",
        //         LastName = "Doe",
        //         Email = "john.doe@gmail.com",
        //         Phone = "123456789"
        //     },
        //     new()
        //     {
        //         IdAccount = 2,
        //         IdRole = 2,
        //         FirstName = "Alice",
        //         LastName = "Smith",
        //         Email = "alice.smith@gmail.com",
        //         Phone = "987654321"
        //     },
        //     new()
        //     {
        //         IdAccount = 3,
        //         IdRole = 3,
        //         FirstName = "Bob",
        //         LastName = "Brown",
        //         Email = "bob.brown@gmail.com",
        //         Phone = "456789123"
        //     }
        // });
        //
        // modelBuilder.Entity<Product>().HasData(new List<Product>()
        // {
        //     new()
        //     {
        //         IdProduct = 1,
        //         Name = "Product 1",
        //         ProductWidth = 1.1m,
        //         ProductHeight = 2.2m,
        //         ProductDepth = 3.3m
        //     },
        //     new()
        //     {
        //         IdProduct = 2,
        //         Name = "Product 2",
        //         ProductWidth = 2m,
        //         ProductHeight = 3.4m,
        //         ProductDepth = 1.4m
        //     },
        //     new()
        //     {
        //         IdProduct = 3,
        //         Name = "Product 3",
        //         ProductWidth = 1.1m,
        //         ProductHeight = 2.2m,
        //         ProductDepth = 3.3m
        //     }
        // });
        //
        // modelBuilder.Entity<ShoppingCard>().HasData(new List<ShoppingCard>()
        // {
        //     new()
        //     {
        //         IdAccount = 1,
        //         IdProduct = 1,
        //         Amount = 13
        //     },
        //     new()
        //     {
        //         IdAccount = 2,
        //         IdProduct = 3,
        //         Amount = 2
        //     },
        //     new()
        //     {
        //         IdAccount = 3,
        //         IdProduct = 2,
        //         Amount = 5
        //     }
        // });
        //
        // modelBuilder.Entity<Category>().HasData(new List<Category>()
        // {
        //     new()
        //     {
        //         IdCategory = 1,
        //         Name = "Category 1"
        //     },
        //     new()
        //     {
        //         IdCategory = 2,
        //         Name = "Category 2"
        //     },
        //     new()
        //     {
        //         IdCategory = 3,
        //         Name = "Category 3"
        //     }
        // });
        //
        // modelBuilder.Entity<ProductCategory>().HasData(new List<ProductCategory>()
        // {
        //     new()
        //     {
        //         IdProduct = 1,
        //         IdCategory = 1
        //     },
        //     new()
        //     {
        //         IdProduct = 2,
        //         IdCategory = 2
        //     },
        //     new()
        //     {
        //         IdProduct = 3,
        //         IdCategory = 3
        //     }
        // });    
    }
}