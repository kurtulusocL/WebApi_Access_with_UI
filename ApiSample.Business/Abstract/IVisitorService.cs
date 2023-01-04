using ApiSample.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiSample.Business.Abstract
{
    public interface IVisitorService
    {
        List<Visitor> GetAll();
        Visitor GetById(int id);
        void Create(Visitor entity);
        void Update(Visitor entity);
        void Delete(Visitor entity);
    }
}
