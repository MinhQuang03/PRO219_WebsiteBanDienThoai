using System.ComponentModel.DataAnnotations;

namespace PRO219_WebsiteBanDienThoai.Models
{
    public class BillPhoneDetail
    {
        public Guid BillDetailId { get; set; }
        public Guid PhoneDetailId { get; set; }
        public virtual BillDetails? BillDetails { get; set; }
        public virtual PhoneDetaild? PhoneDetaild { get; set; }
    }
}
