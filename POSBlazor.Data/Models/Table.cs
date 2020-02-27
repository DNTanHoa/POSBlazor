using System;
using System.Collections.Generic;
using System.Text;

namespace POSBlazor.Data.Models
{
    public class Table : BaseModel
    {
        public string TableName { get; set; }
        public string TableCode { get; set; }
        public int PeopleNumber { get; set; }
        public int StatusId { get; set; }
        public string RegionId { get; set; }
        public string CreateUser { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
