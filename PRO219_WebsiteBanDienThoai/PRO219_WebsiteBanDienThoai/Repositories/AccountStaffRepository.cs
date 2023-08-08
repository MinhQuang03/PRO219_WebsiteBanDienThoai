using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using PRO219_WebsiteBanDienThoai.IRepositories;
using PRO219_WebsiteBanDienThoai.Models;

namespace PRO219_WebsiteBanDienThoai.Repositories;

public class AccountStaffRepository : IAccountStaffRepository
{
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly SignInManager<ApplicationUser> _signInManager;
    private readonly IConfiguration _configuration;

    public AccountStaffRepository(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager,
        IConfiguration configuration)
    {
        _userManager = userManager;
        _signInManager = signInManager;
        _configuration = configuration;
    }

    public AccountStaffRepository()
    {
       
    }

    public async Task<IdentityResult> SignUpAsyns(SignUpModel model)
    {
        ApplicationUser user = new ApplicationUser
        {
            Name = model.FullName,
            Email = model.Email,
            Address = model.Address,
            UserName = model.UserName,
            CitizenId = model.CitizenId,
            PhoneNumber = model.PhoneNumber,
            Status = model.Status,
            ImageUrl = model.ImageUrl
        };
        return await _userManager.CreateAsync(user, model.Password);
    }

    public async Task<string> SignInAsyns(SignInModel model)
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