using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PRO219_WebsiteBanDienThoai.Models;

namespace PRO219_WebsiteBanDienThoai.Configurations
{
    public class RomConfiguration : IEntityTypeConfiguration<Rom>
    {
        public void Configure(EntityTypeBuilder<Rom> builder)
        {
            builder.HasKey(p => p.Id);
        }
    }
}
