using System;
using System.Collections.Generic;
using System.Text;

namespace POSBlazor.Data.Models
{
    public class Region : BaseModel
    {
        public string RegionName { get; set; }
        public string RegionCode { get; set; }
        public string ShopId { get; set; }
        public int StatusId { get; set; }
        public string CreateUser { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
