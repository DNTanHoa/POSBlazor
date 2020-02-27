using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POSBlazor.MVC.Models.Shop
{
    public class ShopListViewModel
    {
        public ShopListViewModel() 
        {
            this.shops = new List<Data.Models.Shop>();
        }

        public List<Data.Models.Shop> shops { get; set; }
    }
}
