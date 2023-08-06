using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PRO219_WebsiteBanDienThoai.Models;

namespace PRO219_WebsiteBanDienThoai.Configurations
{
    public class ChipCPUConfiguration : IEntityTypeConfiguration<ChipCPUs>
    {
        public void Configure(EntityTypeBuilder<ChipCPUs> builder)
        {
            builder.HasKey(p => p.Id);
        }
    }
}
