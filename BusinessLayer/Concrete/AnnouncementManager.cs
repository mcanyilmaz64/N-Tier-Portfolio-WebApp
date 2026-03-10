using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AnnouncementManager : IAnnouncementService
    {
        IAnnouncementDal announcementdal;

        public AnnouncementManager(IAnnouncementDal announcementdal)
        {
            this.announcementdal = announcementdal;
        }

        public Announcement GetById(int id)
        {
          return announcementdal.GetByID(id);
        }

        public List<Announcement> GetList()
        {
            return announcementdal.GetList();
        }

        public void TAdd(Announcement t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Announcement t)
        {
            throw new NotImplementedException();
        }

		public List<Announcement> TGetListbyFilter()
		{
			throw new NotImplementedException();
		}

		public void TUpdate(Announcement t)
        {
            throw new NotImplementedException();
        }
    }
}
