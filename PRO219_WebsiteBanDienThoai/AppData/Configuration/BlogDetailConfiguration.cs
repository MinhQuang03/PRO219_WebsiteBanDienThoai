using AppData.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Configuration
{
    public class BlogDetailConfiguration : IEntityTypeConfiguration<BlogDetail>
    {
        public void Configure(EntityTypeBuilder<BlogDetail> builder)
        {
            builder.HasKey(p => p.Id);

            builder.HasOne(p => p.Blogs).WithMany().HasForeignKey(p => p.IdBlog);
        }
    }
}
