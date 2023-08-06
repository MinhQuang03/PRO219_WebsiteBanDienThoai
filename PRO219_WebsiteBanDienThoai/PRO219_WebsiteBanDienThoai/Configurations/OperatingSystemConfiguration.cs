using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PRO219_WebsiteBanDienThoai.Models;

namespace PRO219_WebsiteBanDienThoai.Configurations
{
    public class OperatingSystemConfiguration : IEntityTypeConfiguration<OperatingSystems>
    {
        public void Configure(EntityTypeBuilder<OperatingSystems> builder)
        {
            builder.HasKey(p => p.Id);
        }
    }
}
