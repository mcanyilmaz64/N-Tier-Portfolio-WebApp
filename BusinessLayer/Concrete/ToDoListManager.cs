using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class ToDoListManager : IToDoListService
	{
		private readonly IToDoListDal _toDoListDal;
        public ToDoListManager(IToDoListDal toDoListDal )
        {
            _toDoListDal = toDoListDal;
        }
        public ToDoList GetById(int id)
		{
			return _toDoListDal.GetByID(id);
		}

		public List<ToDoList> GetList()
		{
			return _toDoListDal.GetList();
		}

		public void TAdd(ToDoList t)
		{
			_toDoListDal.Insert(t);
		}

		public void TDelete(ToDoList t)
		{
			_toDoListDal.Delete(t);
		}

		public List<ToDoList> TGetListbyFilter()
		{
			throw new NotImplementedException();
		}

		public void TUpdate(ToDoList t)
		{
			_toDoListDal.Update(t);
		}
	}
}
