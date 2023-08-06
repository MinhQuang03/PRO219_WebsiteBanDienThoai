namespace PRO219_WebsiteBanDienThoai.Models
{
    public class Rank
    {
        public Guid Id { get; set; }

        public Guid IdAccount { get; set; }
        public string RankName { get; set; }    

        public int? Requirement { get; set; }

        public DateTime? DateRank { get; set; }


        public string? Policies { get; set; }
    }
}
