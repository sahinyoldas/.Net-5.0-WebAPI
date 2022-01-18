using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using DataAccess.Abstract;
using DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.AutoFac
{
    public class AutoFacDependenciesResolverModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<AlbumServiceManager>().As<IAlbumService>().SingleInstance();
            builder.RegisterType<AlbumDalRepository>().As<IAlbumDal>().SingleInstance();
        }
    }
}
