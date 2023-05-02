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
    public class EfPublisherDal : IPublisherDal
    {
        AppDbContext _context = new AppDbContext();

        public void Add(Publisher publisher)
        {
            _context.Publishers.Add(publisher);
            _context.SaveChanges();
        }

        public void Delete(Publisher publisher)
        {
            _context.Publishers.Remove(publisher);
            _context.SaveChanges();

        }

        public List<Publisher> GetAll()
        {
            return _context.Publishers.Where(x=>x.IsDeleted!=true).ToList();
        }

        public Publisher GetById(int publisherId)
        {
            return _context.Publishers.Find(publisherId);
        }

        public void Update(Publisher publisher)
        {
            var result = _context.Publishers.Find(publisher.Id);
            if (result!=null)
            {
                result.Name = publisher.Name;
                _context.SaveChanges();

            }

        }
    }
}
