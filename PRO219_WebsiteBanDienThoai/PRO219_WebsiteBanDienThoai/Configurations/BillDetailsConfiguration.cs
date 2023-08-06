using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PRO219_WebsiteBanDienThoai.Models;

namespace PRO219_WebsiteBanDienThoai.Configurations
{
    public class BillDetailsConfiguration : IEntityTypeConfiguration<BillDetails>
    {
        public void Configure(EntityTypeBuilder<BillDetails> builder)
        {
            builder.HasKey(p => p.Id);

            builder.HasOne(p => p.PhoneDetailds).WithMany().HasForeignKey(p => p.IdPhoneDetaild);

            builder.HasOne(p => p.Discounts).WithMany().HasForeignKey(p => p.IdDiscount);

            builder.HasOne(p => p.Bills).WithMany().HasForeignKey(p => p.IdBill);
        }
    }
}
