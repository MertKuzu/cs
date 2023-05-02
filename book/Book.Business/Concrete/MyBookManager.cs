using Book.Business.Abstract;
using Book.DAL.Concrete.EntityFramework;
using Book.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Business.Concrete
{
    public class MyBookManager : IMyBookService
    {
        EfMyBookDal _myBookDal = new EfMyBookDal();

        public void Add(MyBook myBook)
        {
            _myBookDal.Add(myBook);
        }

        public void Delete(MyBook myBook)
        {
            _myBookDal.Delete(myBook);
        }

        public List<MyBook> GetAll()
        {
            return _myBookDal.GetAll();
        }

        public MyBook GetById(int myBookId)
        {
            return _myBookDal.GetById(myBookId);
        }

        public void Update(MyBook myBook)
        {
            _myBookDal.Update(myBook);
        }
    }
}
