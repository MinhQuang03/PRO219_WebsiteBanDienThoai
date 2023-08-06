﻿namespace PRO219_WebsiteBanDienThoai.Models
{
    public class Transaction
    {
        public Guid Id { get; set; }

        public string Name { get; set; }


        public int Status { get; set; }

        public Guid IdPayment { get; set; }

        public Guid IdBill { get; set; }

        public virtual Payment Payments { get; set; }

        public virtual Bill Bills { get; set; }


    }
}
