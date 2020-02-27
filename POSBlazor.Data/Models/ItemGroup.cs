using System;
using System.Collections.Generic;
using System.Text;

namespace POSBlazor.Data.Models
{
    public class ItemGroup : BaseModel
    {
        public string ItemGroupName { get; set; }
        public string ItemGroupCode { get; set; }
        public string CreateUser { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
