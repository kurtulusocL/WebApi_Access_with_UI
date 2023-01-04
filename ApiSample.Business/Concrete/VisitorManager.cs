using ApiSample.Business.Abstract;
using ApiSample.DataAccess.Abstract;
using ApiSample.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiSample.Business.Concrete
{
    public class VisitorManager : IVisitorService
    {
        private readonly IVisitorDal _visitorDal;
        public VisitorManager(IVisitorDal visitorDal)
        {
            _visitorDal = visitorDal;
        }
        public void Create(Visitor entity)
        {
            if (entity==null)
            {
                throw new ArgumentNullException(nameof(entity));
            }
            _visitorDal.Add(entity);
        }

        public void Delete(Visitor entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }
            _visitorDal.Delete(entity);
        }

        public List<Visitor> GetAll()
        {
            return _visitorDal.GetAll();
        }

        public Visitor GetById(int id)
        {
            return _visitorDal.Get(i => i.Id == id);
        }

        public void Update(Visitor entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }
            _visitorDal.Update(entity);
        }
    }
}
