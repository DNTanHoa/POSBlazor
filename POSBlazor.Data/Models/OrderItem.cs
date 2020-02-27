using System;
using System.Collections.Generic;
using System.Text;

namespace POSBlazor.Data.Models
{
    public class OrderItem : BaseModel
    {
        public int ItemId { get; set; }
        public int Quantity { get; set; }
        public int OrderId { get; set; }
        public int StatusId { get; set; }
        public string CreateUser { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
