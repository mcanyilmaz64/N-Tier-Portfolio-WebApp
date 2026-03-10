using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Dashboard
{
	public class ProjectList :ViewComponent
	{
		PortfolioManager portfolioManager = new PortfolioManager(new EFPortfolioDal());
		public IViewComponentResult Invoke()
		{
			var values = portfolioManager.GetList();
			return View(values);
		}
	}
}
