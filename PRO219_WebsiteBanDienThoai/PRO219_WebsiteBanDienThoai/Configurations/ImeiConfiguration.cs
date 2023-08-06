using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PRO219_WebsiteBanDienThoai.Models;

namespace PRO219_WebsiteBanDienThoai.Configurations
{
    public class ImeiConfiguration : IEntityTypeConfiguration<Imei>
    {
        public void Configure(EntityTypeBuilder<Imei> builder)
        {
            builder.HasKey(p => p.Id);

            builder.HasOne(p => p.PhoneDetailds).WithMany().HasForeignKey(p => p.IdPhoneDetaild);
        }
    }
}
