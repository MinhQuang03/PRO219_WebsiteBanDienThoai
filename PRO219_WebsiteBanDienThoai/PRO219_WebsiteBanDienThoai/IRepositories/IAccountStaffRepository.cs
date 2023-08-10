using Microsoft.AspNetCore.Identity;
using PRO219_WebsiteBanDienThoai.Models;

namespace PRO219_WebsiteBanDienThoai.IRepositories
{
    public interface IAccountStaffRepository
    {
        public Task<IdentityResult> SignUpAsyns(SignUpModel model);
        public Task<string> SignInAsyns(SignInModel model);
        
    }
}
