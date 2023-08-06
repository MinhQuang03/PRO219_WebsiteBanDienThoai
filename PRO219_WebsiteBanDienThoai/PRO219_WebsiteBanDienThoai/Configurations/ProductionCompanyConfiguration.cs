using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PRO219_WebsiteBanDienThoai.Models;

namespace PRO219_WebsiteBanDienThoai.Configurations
{
    public class ProductionCompanyConfiguration : IEntityTypeConfiguration<ProductionCompany>
    {
        public void Configure(EntityTypeBuilder<ProductionCompany> builder)
        {
            builder.HasKey(p => p.Id);
        }
    }
}
