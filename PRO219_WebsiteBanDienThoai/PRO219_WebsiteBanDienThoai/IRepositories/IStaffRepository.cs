using PRO219_WebsiteBanDienThoai.Models;

namespace PRO219_WebsiteBanDienThoai.IRepositories
{
    public interface IStaffRepository
    {
        public bool Create(ApplicationUser obj);
        public bool Update(ApplicationUser obj);
        public bool Delete(ApplicationUser obj);
        public List<ApplicationUser> GetAll();
        public List<ApplicationUser> GetAllByEmail(string email);

    }
}
