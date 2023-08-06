using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PRO219_WebsiteBanDienThoai.Models;

namespace PRO219_WebsiteBanDienThoai.Configurations
{
    public class ListImageConfiguration : IEntityTypeConfiguration<ListImage>
    {
        public void Configure(EntityTypeBuilder<ListImage> builder)
        {
            builder.HasKey(p => p.Id);

            builder.HasOne(p => p.PhoneDetailds).WithMany().HasForeignKey(p => p.IdPhoneDetaild);
        }
    }
}
