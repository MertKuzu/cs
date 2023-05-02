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
    public class PublisherManager : IPublisherService
    {
        EfPublisherDal _publisherDal = new EfPublisherDal();

        public void Add(Publisher publisher)
        {
            _publisherDal.Add(publisher);
        }

        public void Delete(Publisher publisher)
        {
            _publisherDal.Delete(publisher);
        }

        public List<Publisher> GetAll()
        {
            return _publisherDal.GetAll();
        }

        public Publisher GetById(int publisherId)
        {
            return _publisherDal.GetById(publisherId);
        }

        public void Update(Publisher publisher)
        {
            _publisherDal.Update(publisher);
        }
    }
}
