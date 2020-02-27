using System;
using System.Collections.Generic;
using System.Text;

namespace POSBlazor.Data.Models
{
    public class Shop : BaseModel
    {
        public string ShopName { get; set; }
        public string ShopCode { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public int StatusId { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public string CreateUser { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
