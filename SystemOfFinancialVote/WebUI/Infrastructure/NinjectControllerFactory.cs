using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Routing;
using Ninject;
using Model.Abstract;
using Model.Concrete;
using Model.Entities;
using Moq;

namespace WebUI.Infrastructure
{
    public class NinjectControllerFactory : DefaultControllerFactory
    {
        private IKernel ninjectKernel;

        public NinjectControllerFactory()
        {
            // создание контейнера
            ninjectKernel = new StandardKernel();
            AddBindings();
        }

        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            // получение объекта контроллера из контейнера
            // используя его тип
            return controllerType == null
                ? null
                : (IController)ninjectKernel.Get(controllerType);
        }

        private void AddBindings()
        {
            
            var proposals = new Mock<IRepository<Proposal>>();
            proposals.Setup(x => x.Get(null,null,"")).Returns(new List<Proposal>()
            {
                new Proposal(){Name = "first proposal", Price = 500},
                new Proposal() {Name ="second proposal", Price=1000}
            }.AsQueryable());
            var repo=new Mock<ISuperRepository>();
            repo.Setup(x => x.Proposals).Returns(proposals.Object);
            ninjectKernel.Bind<ISuperRepository>().To<EFSuperRepository>();
            //ninjectKernel.Bind<ISuperRepository>().ToConstant(repo.Object);
        }
    }
}