﻿namespace PRO219_WebsiteBanDienThoai.Models
{
    public class Warranty
    {
        public Guid Id { get; set; }

        public Guid IdPhone { get; set; }

        public DateTime Time { get; set; }

        public string? Description { get; set; }

        public virtual Phone Phones { get; set; }
    }
}
