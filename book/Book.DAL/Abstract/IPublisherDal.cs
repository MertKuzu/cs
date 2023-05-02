using Book.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.DAL.Abstract
{
    public interface IPublisherDal
    {
        List<Publisher> GetAll();

        Publisher GetById(int publisherId);

        void Add(Publisher publisher);

        void Update(Publisher publisher);

        void Delete(Publisher publisher);
    }
}
