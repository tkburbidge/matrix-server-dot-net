using Matrix.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix.Domain.DependencyInjection
{
    public class RepositoryFactory
    {
        private IServiceProvider serviceProvider;

        public RepositoryFactory(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        public IUserRepository UserRepository { get { return (IUserRepository)this.serviceProvider.GetService(typeof(IUserRepository)); } }
    }
}
