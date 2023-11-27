using AppData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.IRepositories
{
    public interface IBlogDetailRepository
    {
        Task<BlogDetail> Add(BlogDetail obj);
        Task<BlogDetail> Update(BlogDetail obj);

        Task<List<BlogDetail>> GetAll();
        Task<List<BlogDetail>> GetAll(Guid IdBlog);

        Task<BlogDetail> GetById(Guid id);
    }
}
