using Matrix.Domain.DependencyInjection;
using Matrix.Services.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix.Services.Concrete
{
    public class Service
    {
        protected ServiceFactory serviceFactory;
        protected RepositoryFactory repositoryFactory;

        public Service(ServiceFactory serviceFactory, RepositoryFactory repositoryFactory)
        {
            this.serviceFactory = serviceFactory;
            this.repositoryFactory = repositoryFactory;
        }
    }
}
