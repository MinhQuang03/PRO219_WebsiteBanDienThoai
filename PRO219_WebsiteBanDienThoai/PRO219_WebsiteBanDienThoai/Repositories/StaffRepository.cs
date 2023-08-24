using PRO219_WebsiteBanDienThoai.IRepositories;
using PRO219_WebsiteBanDienThoai.Models;

namespace PRO219_WebsiteBanDienThoai.Repositories
{
    public class StaffRepository:IStaffRepository
    {
        private ShoppingDbContext _shoppingDbContext;

        public StaffRepository(ShoppingDbContext context)
        {
            _shoppingDbContext = context;
        }
        public bool Create(ApplicationUser obj)
        {
            try
            {
                _shoppingDbContext.Add(obj);
                _shoppingDbContext.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool Update(ApplicationUser obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(ApplicationUser obj)
        {
            throw new NotImplementedException();
        }

        public List<ApplicationUser> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<ApplicationUser> GetAllByEmail(string email)
        {
            throw new NotImplementedException();
        }
    }
}
