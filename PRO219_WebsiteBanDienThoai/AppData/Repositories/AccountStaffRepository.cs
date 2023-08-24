using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using AppData.IRepositories;
using AppData.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace AppData.Repositories
{
    public class AccountStaffRepository : IAccountStaffRepository
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IConfiguration _configuration;

        public AccountStaffRepository()
        {
            
        }

        public AccountStaffRepository(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, IConfiguration configuration)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _configuration = configuration;
        }

        public async Task<IdentityResult> SignUpAsync(SignUpModel model)
        {
            var user = new ApplicationUser
            {
                Name = model.FullName,
                Email = model.Email,
                Address = model.Address,
                CitizenId = model.CitizenId,
                PhoneNumber = model.PhoneNumber,
                Status = model.Status,
                ImageUrl = model.ImageUrl,
                PasswordHash = model.Password,
                UserName = model.UserName,
            };
            return await _userManager.CreateAsync(user, model.Password);
        }

        public async Task<string> SignInAsync(SignInModel model)
        {
            var result = await _signInManager.PasswordSignInAsync(model.UserName, model.Password, false, false);
            if (!result.Succeeded) return string.Empty;

            var authClaims = new List<Claim>
            {
                new(ClaimTypes.Email, model.Email),
                new(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

            var authenKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Secret"]));

            var token = new JwtSecurityToken(
                issuer: _configuration["JWT:ValidIssuer"],
                audience: _configuration["JWT:ValidAudienc"],
                expires: DateTime.Now.AddHours(3),
                claims: authClaims,
                signingCredentials: new SigningCredentials(authenKey, SecurityAlgorithms.HmacSha512Signature)
            );
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
