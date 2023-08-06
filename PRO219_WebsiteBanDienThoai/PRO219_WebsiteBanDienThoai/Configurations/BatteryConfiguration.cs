using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PRO219_WebsiteBanDienThoai.Models;

namespace PRO219_WebsiteBanDienThoai.Configurations
{
    public class BatteryConfiguration : IEntityTypeConfiguration<Battery>
    {
        public void Configure(EntityTypeBuilder<Battery> builder)
        {
            builder.HasKey(p => p.Id);
        }
    }
}
