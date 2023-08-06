using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PRO219_WebsiteBanDienThoai.Models;

namespace PRO219_WebsiteBanDienThoai.Configurations
{
    public class ChipGPUConfiguration : IEntityTypeConfiguration<ChipGPUs>
    {
        public void Configure(EntityTypeBuilder<ChipGPUs> builder)
        {
            builder.HasKey(p => p.Id);
        }
    }
}
