using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace PRO219_WebsiteBanDienThoai.Models
{
    public class ShoppingDbContext : DbContext
    {
        public ShoppingDbContext()
        {
            
        }

        public ShoppingDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Account> Accounts { get; set; }    

        public DbSet<Address> Address { get; set; }

        public DbSet<Battery> Battery { get; set; }

        public DbSet<Bill> Bill { get; set; }

        public DbSet<BillDetails> BillDetails { get; set; }

        public DbSet<Blog> Blogs { get; set; }

        public DbSet<Cart> Carts { get; set; }  

        public DbSet<CartDetails> CartsDetails { get; set; }

        public DbSet<ChargingportType> ChargingportType { get; set; }

        public DbSet<ChipCPUs> ChipCPUs { get; set; }

        public DbSet<ChipGPUs> ChipGPUs { get; set; }

        public DbSet<Color> Colors { get; set; }

        public DbSet<Discount> Discount { get; set; }

        public DbSet<Imei> Imei { get; set; }

        public DbSet<ListImage> ListImage { get; set; }

        public DbSet<Material> Material { get; set; }

        public DbSet<OperatingSystems> OperatingSystem { get; set; } 

        public DbSet<Payment> Payments { get; set; }

        public DbSet<Phone> Phones { get; set; }

        public DbSet<PhoneDetaild> PhoneDetailds { get; set; }

        public DbSet<ProductionCompany> ProductionCompany { get; set; }

        public DbSet<Ram> Ram { get; set; } 

        public DbSet<Rank> Ranks { get; set; }

        public DbSet<Review> Reviews { get; set; }  

        public DbSet<Role> Roles { get; set; }

        public DbSet<Rom> Rom { get; set; } 

        public DbSet<Sim> Sim { get; set; }

        public DbSet<Staff> Staff { get; set; }

        public DbSet<Transaction> Transactions { get; set; }

        public DbSet<Warranty> Warranty { get; set;}

        public DbSet<WarrantyCard> WarrantyCards { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=PRO219_WebsiteBanDienThoai;User ID=QuangBm36;Password=123456;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
