using System;
using System.Collections.Generic;
using System.Text;

namespace POSBlazor.Data.Models
{
    public class Order : BaseModel
    {
        public string OrderCode { get; set; }
        public int TableId { get; set; }
        public int StatusId { get; set; }
        public string CreateUser { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
