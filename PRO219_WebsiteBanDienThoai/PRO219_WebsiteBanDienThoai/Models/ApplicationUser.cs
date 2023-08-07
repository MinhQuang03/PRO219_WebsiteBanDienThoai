﻿using Microsoft.AspNetCore.Identity;

namespace PRO219_WebsiteBanDienThoai.Models
{
    public class ApplicationUser : IdentityUser
    {
        public int? CitizenId { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? ImageUrl { get; set; }
        public int Status { get; set; }
    }
}
