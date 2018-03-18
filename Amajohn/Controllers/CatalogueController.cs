using Amajohn.DAL;
using Amajohn.ViewModels;
using System.Linq;
using System.Web.Mvc;

namespace Amajohn.Controllers
{
    public class CatalogueController : Controller
    {
        private AmajohnContext db;
        public int PageSize = 4;

        public ActionResult Index(string category, int page = 1)
        {
            db = new AmajohnContext();
            ProductsListViewModel model = new ProductsListViewModel
            {
                Products = db.Products
                    .Where(p => category == null || p.Category == category)
                    .OrderBy(p => p.ProductId)
                    .Skip((page - 1) * PageSize)
                    .Take(PageSize),

                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalItems = category == null ?
                        db.Products.Count() :
                        db.Products.Where(e => e.Category == category).Count()
                },

                CurrentCategory = category
            };
            return View(model);
        }
    }
}