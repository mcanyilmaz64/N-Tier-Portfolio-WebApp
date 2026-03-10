using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Dashboard
{
    public class Last5Project : ViewComponent
    {
        Context c = new Context();

        public IViewComponentResult Invoke()
        {
            //ViewBag.v1 = c.Portfolios.Where(x =>x.PortfolioId );
           

            return View();
        }

    }
}
