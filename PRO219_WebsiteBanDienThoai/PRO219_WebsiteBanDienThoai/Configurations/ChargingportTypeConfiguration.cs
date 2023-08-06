using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PRO219_WebsiteBanDienThoai.Models;

namespace PRO219_WebsiteBanDienThoai.Configurations
{
    public class ChargingportTypeConfiguration : IEntityTypeConfiguration<ChargingportType>
    {
        public void Configure(EntityTypeBuilder<ChargingportType> builder)
        {
            builder.HasKey(p => p.Id);
        }
    }
}
