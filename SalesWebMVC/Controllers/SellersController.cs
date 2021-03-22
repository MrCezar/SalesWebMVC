using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.Services;

namespace SalesWebMvc.Controllers
{
    public class SellersController : Controller
    {
        private readonly SellerService _selleService;

        public SellersController(SellerService selleService)
        {
            _selleService = selleService;
        }
        public IActionResult Index()
        {
            var sellersList = _selleService.FindAll();
            return View(sellersList);
        }
    }
}
