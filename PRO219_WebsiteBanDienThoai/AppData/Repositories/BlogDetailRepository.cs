using AppData.FPhoneDbContexts;
using AppData.IRepositories;
using AppData.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Repositories
{
    public class BlogDetailRepository : IBlogDetailRepository
    {
        public readonly FPhoneDbContext _dbContext;
        public BlogDetailRepository(FPhoneDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<BlogDetail> Add(BlogDetail obj)
        {
            await _dbContext.BlogDetails.AddAsync(obj);
            await _dbContext.SaveChangesAsync();
            return obj;
        }

        public async Task<List<BlogDetail>> GetAll()
        {
            return await _dbContext.BlogDetails.ToListAsync();
        }

        public async Task<List<BlogDetail>> GetAll(Guid IdBlog)
        {
            return await _dbContext.BlogDetails.Where(c => c.IdBlog == IdBlog).ToListAsync();
        }

        public async Task<BlogDetail> GetById(Guid id)
        {
            return await _dbContext.BlogDetails.FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<BlogDetail> Update(BlogDetail obj)
        {
            var a = await _dbContext.BlogDetails.FindAsync(obj.Id);
            a.IdBlog = obj.IdBlog;
            a.Content = obj.Content;
            a.Image = obj.Image;
            _dbContext.BlogDetails.Update(a);
            await _dbContext.SaveChangesAsync();
            return obj;
        }
    }
}
