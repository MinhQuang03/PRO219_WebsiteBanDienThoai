using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PRO219_WebsiteBanDienThoai.Models;

namespace PRO219_WebsiteBanDienThoai.Configurations
{
    public class SimConfiguration : IEntityTypeConfiguration<Sim>
    {
        public void Configure(EntityTypeBuilder<Sim> builder)
        {
            builder.HasKey(p => p.Id);
        }
    }
}
