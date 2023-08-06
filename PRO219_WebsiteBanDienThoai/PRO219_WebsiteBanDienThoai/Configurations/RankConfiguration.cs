using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PRO219_WebsiteBanDienThoai.Models;

namespace PRO219_WebsiteBanDienThoai.Configurations
{
    public class RankConfiguration : IEntityTypeConfiguration<Rank>
    {
        public void Configure(EntityTypeBuilder<Rank> builder)
        {
            builder.HasKey(p => p.Id);
        }
    }
}
