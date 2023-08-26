﻿using System.ComponentModel.DataAnnotations;

namespace PRO219_WebsiteBanDienThoai.Models
{
    public class Cart
    {
      
        public Guid? IdAccount { get; set; }

        public string? Description { get; set; }

        public Account Accounts { get; set; }

    }
}