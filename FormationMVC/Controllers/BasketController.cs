using FormationMVC.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FormationMVC.Controllers
{
    public class BasketController : Controller
    {
        // GET: Basket
        public ActionResult Index()
        {
            IBasket basket = UnityHelper.Resolve<IBasket>();
            ViewBag.Basket = basket;
            return View();
        }

        public ActionResult Add(int id)
        {
            IMainService service = UnityHelper.Resolve<IMainService>();
            ViewBag.Basket = service.AddProductToBasketByProductId(id);
            return View("Index");
        }

        public ActionResult Remove(int id)
        {
            IMainService service = UnityHelper.Resolve<IMainService>();
            ViewBag.Basket = service.RemoveProductFromBasketByProductId(id);
            return View("Index");
        }
    }
}