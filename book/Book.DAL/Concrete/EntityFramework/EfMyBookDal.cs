using Book.DAL.Abstract;
using Book.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Book.DAL.Concrete.EntityFramework
{
    public class EfMyBookDal : IMyBookDal
    {
        AppDbContext _context = new AppDbContext();

        public void Add(MyBook myBook)
        {
            _context.MyBooks.Add(myBook);
            _context.SaveChanges();
        }

        public void Delete(MyBook myBook)
        {
            _context.MyBooks.Remove(myBook);
            _context.SaveChanges();

        }

        public List<MyBook> GetAll()
        {
            return _context.MyBooks.Where(x=>x.IsDeleted!=true).ToList();
        }

        public MyBook GetById(int myBookId)
        {
            return _context.MyBooks.Find(myBookId);
        }

        public void Update(MyBook myBook)
        {
            var result = _context.MyBooks.Find(myBook.Id);
            if (result!=null)
            {
                result.Name = myBook.Name;
                _context.SaveChanges();

            }

        }
    }
}
