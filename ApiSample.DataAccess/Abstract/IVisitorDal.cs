using ApiSample.Core.DataAccess;
using ApiSample.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiSample.DataAccess.Abstract
{
    public interface IVisitorDal : IEntityRepository<Visitor>
    {
    }
}
