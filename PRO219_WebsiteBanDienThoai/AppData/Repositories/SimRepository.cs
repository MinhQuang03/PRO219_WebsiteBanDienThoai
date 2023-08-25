using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppData.FPhoneDbContexts;
using AppData.IRepositories;
using AppData.Models;
using Microsoft.AspNetCore.Identity;

namespace AppData.Repositories
{
    public class SimRepository:ISimRepository
    {
        private FPhoneDbContext _dbContext;
        public SimRepository(FPhoneDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<bool> Create(Sim obj)
        {
            try
            {
                _dbContext.Add(obj);
                 await _dbContext.SaveChangesAsync();
               return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }
    }
}
