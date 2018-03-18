using Amajohn.Infrastructure;
using System;
using Amajohn.DAL;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Amajohn.Controllers
{
    public class NavController : Controller
    {
        private AmajohnContext db = new AmajohnContext();

        public PartialViewResult Menu(string category = null)
        {
            ViewBag.SelectedCategory = category;

            IEnumerable<string> categories = db.Products
                                                       .Select(x => x.Category)
                                                       .Distinct()
                                                       .OrderBy(x => x);
            return PartialView(categories);
        }
    }
}
