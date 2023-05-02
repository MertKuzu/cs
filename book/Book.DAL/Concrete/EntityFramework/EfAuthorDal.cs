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
    public class EfAuthorDal : IAuthorDal
    {
        AppDbContext _context = new AppDbContext();

        public void Add(Author author)
        {
            _context.Authors.Add(author);
            _context.SaveChanges();
        }

        public void Delete(Author author)
        {
            _context.Authors.Remove(author);
            _context.SaveChanges();

        }

        public List<Author> GetAll()
        {
            return _context.Authors.Where(x=>x.IsDeleted!=true).ToList();
        }

        public Author GetById(int authorId)
        {
            return _context.Authors.Find(authorId);
        }

        public void Update(Author author)
        {
            var result = _context.Authors.Find(author.Id);
            if (result!=null)
            {
                result.Name = author.Name;
                _context.SaveChanges();

            }

        }
    }
}
