using ApiSample.Core.DataAccess.EntityFramework;
using ApiSample.DataAccess.Abstract;
using ApiSample.DataAccess.Concrete.EntityFramework.Context;
using ApiSample.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiSample.DataAccess.Concrete.EntityFramework
{
    public class VisitorDal : EntityRepositoryBase<Visitor, ApplicationDbContext>, IVisitorDal
    {
    }
}
