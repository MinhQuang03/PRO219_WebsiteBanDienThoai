using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PRO219_WebsiteBanDienThoai.Models;

namespace PRO219_WebsiteBanDienThoai.Configurations
{
    public class WarrantyConfiguration : IEntityTypeConfiguration<Warranty>
    {
        public void Configure(EntityTypeBuilder<Warranty> builder)
        {
            builder.HasKey(p => p.Id);

            builder.HasOne(p => p.Phones).WithMany().HasForeignKey(p => p.IdPhone);
        }
    }
}
