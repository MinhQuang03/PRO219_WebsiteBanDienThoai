namespace PRO219_WebsiteBanDienThoai.Models
{
    public class Staff
    {
        public Guid Id { get; set; }    

        public Guid IdRole { get; set; }

        public string Usurname { get; set; }    

        public string Password { get; set; }

        public int? CitizenId { get; set; }

        public string? Name { get; set; }

        public string? Email { get; set; }

        public string? Address { get; set; }

        public string PhoneNumber { get; set; }

        public string? ImageUrl { get; set; }

        public int Status { get; set; }

        public virtual Role Roles { get; set; }
    }
}
