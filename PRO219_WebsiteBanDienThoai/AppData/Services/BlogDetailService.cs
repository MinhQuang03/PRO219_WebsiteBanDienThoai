using AppData.FPhoneDbContexts;
using AppData.IRepositories;
using AppData.IServices;
using AppData.Models;
using AppData.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Services
{
    public class BlogDetailService : IBlogDetailService
    {
        public readonly FPhoneDbContext _dbContext;
        private IBlogRepository _iblogRepo;
        private IBlogDetailRepository _iblogDetailRepository;
        public BlogDetailService(FPhoneDbContext dbContext,IBlogRepository iblogRepo, IBlogDetailRepository iblogDetailRepository)
        {
            _dbContext = dbContext;
            _iblogRepo = iblogRepo;
            _iblogDetailRepository = iblogDetailRepository;
        }

        public async Task<BlogDetail> Add(BlogDetail obj)
        {
            await _dbContext.BlogDetails.AddAsync(obj);
            await _dbContext.SaveChangesAsync();
            return obj;
        }

        public async Task<List<BlogDetail>> GetBlogDetailds()
        {
            var results = await _iblogDetailRepository.GetAll();
            foreach (var blogDetail in results)
            {
                blogDetail.Blogs = await _iblogRepo.GetById(blogDetail.IdBlog);
            }
            return results;
        }

        public async Task<List<BlogDetail>> GetBlogDetailds(Guid IdBlog)
        {
            var results = await _iblogDetailRepository.GetAll(IdBlog);
            foreach (var blogDetail in results)
            {
                blogDetail.Blogs = await _iblogRepo.GetById(blogDetail.IdBlog);
            }
            return results;
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
