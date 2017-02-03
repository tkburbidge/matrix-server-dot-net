using Matrix.Domain.Contexts;
using Matrix.Domain.Interfaces;
using Matrix.Domain.Repositories;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix.Domain.DependencyInjection
{
    public class SimpleInjectorRepositoriesInitializer
    {
        public static void InitializeContainer(Container container)
        {
            container.Register(() => new RepositoryFactory(container));
            container.Register<IUserRepository, UserRepository>();
        }
    }
}
