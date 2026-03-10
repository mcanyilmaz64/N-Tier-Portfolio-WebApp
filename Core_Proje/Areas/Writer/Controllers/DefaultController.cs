using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Areas.Writer.Controllers
{
	[Area("Writer")]
	[Authorize]
	public class DefaultController : Controller
	{
		AnnouncementManager manager = new AnnouncementManager(new EfAnnoucementDal());
		public IActionResult Index()
		{
			var values = manager.GetList();
			return View(values);
		}
		[HttpGet]
		public IActionResult Details(int id)
		{
			Announcement announcement = manager.GetById(id);
			return View(announcement);
		}
	}
}
