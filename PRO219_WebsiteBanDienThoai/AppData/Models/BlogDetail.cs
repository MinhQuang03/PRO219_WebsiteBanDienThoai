using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Models
{
    public class BlogDetail
    {
        public Guid Id { get; set; }
        public Guid IdBlog { get; set; }
        public string? Content { get; set; }
        public string? Image { get; set; }
        public virtual Blog Blogs { get; set; }
    }
}
