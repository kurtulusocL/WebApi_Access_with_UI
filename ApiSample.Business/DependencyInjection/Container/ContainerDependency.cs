using ApiSample.Business.Abstract;
using ApiSample.Business.Concrete;
using ApiSample.DataAccess.Abstract;
using ApiSample.DataAccess.Concrete.EntityFramework;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiSample.Business.DependencyInjection.Container
{
    public static class ContainerDependency
    {
        public static void ContainerDependencies(this IServiceCollection services)
        {
            services.AddScoped<IVisitorDal, VisitorDal>();
            services.AddScoped<IVisitorService, VisitorManager>();           
        }
    }
}
