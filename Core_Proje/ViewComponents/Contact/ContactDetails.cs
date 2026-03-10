using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.DotNet.Scaffolding.Shared;

namespace Core_Proje.ViewComponents.Contact
{
	public class ContactDetails : ViewComponent
	{
		ContactManager contactManager = new ContactManager(new EFContactDal());
		public IViewComponentResult Invoke()
		{
			var values = contactManager.GetList();
			return View(values);
		}
	}
}
