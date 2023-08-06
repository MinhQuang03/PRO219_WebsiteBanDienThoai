using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PRO219_WebsiteBanDienThoai.Models;

namespace PRO219_WebsiteBanDienThoai.Configurations
{
    public class WarrantyCardConfiguration : IEntityTypeConfiguration<WarrantyCard>
    {
        public void Configure(EntityTypeBuilder<WarrantyCard> builder)
        {
            builder.HasKey(p => p.Id);

            builder.HasOne(p => p.BillDetails).WithMany().HasForeignKey(p => p.IdBillDetail);
        }
    }
}
