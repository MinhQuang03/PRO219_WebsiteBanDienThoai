using AppData.Models;

namespace AppData.IRepositories
{
    public interface IAccountStaffRepository
    {
        public Task<bool> SignUpAsync(SignUpModel model);
        public Task<string> SignInAsync(SignInModel model);

        public Task<string> GenerateToken(ApplicationUser model);
        public Task<List<ApplicationUser>> GetAllAsync();
        public Task<string> SignOut();
    }
}
