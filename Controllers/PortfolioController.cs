using CronanGogarty.com.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CronanGogarty.com.Controllers
{
    public class PortfolioController : Controller
    {
        // GET: Portfolio
        public ActionResult Index()
        {
            var portfolioService = new PortfolioService();

            IList<IPortfolioItem> items = portfolioService.AllItems();

            return View(items);
        }

        //public ActionResult Random()
        //{
        //    PortfolioItem item = new PortfolioItem() { Title = "ColtPoker.com" };
            
        //    return View(item);
        //}

        public ActionResult ViewItem(byte id)
        {
            var portfolioService = new PortfolioService();

            IPortfolioItem item = portfolioService.GetItem(id);

            return View(item);
        }
    }
}