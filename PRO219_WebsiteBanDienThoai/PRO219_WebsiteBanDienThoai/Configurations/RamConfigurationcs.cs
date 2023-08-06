using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PRO219_WebsiteBanDienThoai.Models;

namespace PRO219_WebsiteBanDienThoai.Configurations
{
    public class RamConfigurationcs : IEntityTypeConfiguration<Ram>
    {
        public void Configure(EntityTypeBuilder<Ram> builder)
        {
            builder.HasKey(p => p.Id);
        }
    }
}
