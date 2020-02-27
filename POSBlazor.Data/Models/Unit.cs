using System;
using System.Collections.Generic;
using System.Text;

namespace POSBlazor.Data.Models
{
    public class Unit : BaseModel
    {
        public string UnitName { get; set; }
        public string UnitCode { get; set; }
        public string CreateUser { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
