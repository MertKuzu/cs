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
    public class EfCategoryDal : ICategoryDal
    {
        AppDbContext _context = new AppDbContext();

        public void Add(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
        }

        public void Delete(Category category)
        {
            category.IsDeleted = true;
            Update(category);


        }

        public List<Category> GetAll()
        {
            return _context.Categories.Where(x=>x.IsDeleted!=true).ToList();
        }

        public Category GetById(int categoryId)
        {
            return _context.Categories.Find(categoryId);
        }

        public void Update(Category category)
        {
            var result = _context.Categories.Find(category.Id);
            if (result!=null)
            {
                result.Name = category.Name;
                _context.SaveChanges();

            }

        }
    }
}
