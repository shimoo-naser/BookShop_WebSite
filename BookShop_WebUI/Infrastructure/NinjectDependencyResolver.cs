using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Collections;
using BookShop_Domain.Abstruct;
using BookShop_Domain.Concrete;
using BookShop_Domain.Entities;
using Ninject;

namespace BookShop_WebUI.Infrastructure
{
    public class NinjectDependencyResolver :IDependencyResolver
    {
        private IKernel kernel;

        public NinjectDependencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
            AddBindings();
        }


        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }



        private void AddBindings()
        {
          
            kernel.Bind<IBookRepository>().To<EFBookRepository>();
        }
    }
}
/*  Mock<IBookRepository> mock = new Mock<IBookRepository>();
            mock.Setup(b => b.Books).Returns(
                new List<Book> {
                    new Book { Title = "A"},
                    new Book { Title = "B"},
                    new Book { Title = "C"},
                    new Book { Title = "D"}
                });*/
