namespace AppData.Models
{
    public class Blog
    {
        public Guid Id { get; set; }

        public string? Title { get; set; }

        public DateTime? CreatedDate { get; set; }

        public int Status { get; set; }
        //public string FileName { get; set; }
        //public string ContentType { get; set; }
        //public byte[] FileContent { get; set; }
    }
}
