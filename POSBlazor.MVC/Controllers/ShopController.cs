using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using POSBlazor.Data.Services.Common;
using POSBlazor.MVC.Models.Shop;
using POSSolution.Application.Context;

namespace POSBlazor.MVC.Controllers
{
    public class ShopController : Controller
    {
        public ServiceBase<Data.Models.Shop> _shopService;

        private readonly POSContext _context;

        public ShopController (POSContext context)
        {
            _context = context;
            _shopService = new ServiceBase<Data.Models.Shop>(_context);
        }

        public IActionResult Index()
        {
            var model = new ShopListViewModel();
            model.shops = _shopService.GetAllToList().Result;
            return View(model);
        }
    }
}