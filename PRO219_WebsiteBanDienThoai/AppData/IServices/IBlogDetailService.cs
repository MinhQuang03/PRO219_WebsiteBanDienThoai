using AppData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.IServices
{
    public interface IBlogDetailService
    {
        Task<BlogDetail> Add(BlogDetail obj);
        Task<BlogDetail> Update(BlogDetail obj);
        public Task<List<BlogDetail>> GetBlogDetailds();
        public Task<List<BlogDetail>> GetBlogDetailds(Guid IdBlog);

        Task<BlogDetail> GetById(Guid id);
    }
}
