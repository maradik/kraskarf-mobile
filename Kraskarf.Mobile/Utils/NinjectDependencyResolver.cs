using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Kraskarf.Mobile.Accessors;
using Kraskarf.Mobile.Repositories;
using Ninject;

namespace Kraskarf.Mobile.Utils
{
    public class NinjectDependencyResolver : IDependencyResolver
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
            kernel.Bind<IDeliveryTypeRepository>().To<DeliveryTypeRepository>();
            kernel.Bind<IPaymentTypeRepository>().To<PaymentTypeRepository>();
            kernel.Bind<IProductGroupRepository>().To<ProductGroupRepository>();

            kernel.Bind<IDeliveryTypeAccessor>().To<DeliveryTypeAccessor>();
            kernel.Bind<IPaymentTypeAccessor>().To<PaymentTypeAccessor>();
            kernel.Bind<IProductGroupAccessor>().To<ProductGroupAccessor>();
        }
    }
}