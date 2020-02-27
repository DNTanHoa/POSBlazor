using System;
using System.Collections.Generic;
using System.Text;

namespace POSBlazor.Data.Models
{
    public class Item : BaseModel
    {
        public string ItemName { get; set; }
        public string ItemCode { get; set; }
        public string ItemImage { get; set; }
        public int ItemGroupId { get; set; }
        public int UnitId { get; set; }
        public decimal Price { get; set; }
        public int StatusId { get; set; }
        public string CreateUser { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
