using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PRO219_WebsiteBanDienThoai.Models;

namespace PRO219_WebsiteBanDienThoai.Configurations
{
    public class AccountConfiguration : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            builder.HasKey(p => p.Id);
        }
    }
}
