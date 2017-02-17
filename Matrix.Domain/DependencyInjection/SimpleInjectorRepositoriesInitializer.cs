using Matrix.Domain.Interfaces;
using Matrix.Domain.Repositories;
using SimpleInjector;

namespace Matrix.Domain.DependencyInjection
{
    public class SimpleInjectorRepositoriesInitializer
    {
        public static void InitializeContainer(Container container)
        {
            container.Register(() => new RepositoryFactory(container));
            container.Register<IAccessTokenRepository, AccessTokenRepository>();
            container.Register<IUserRepository, UserRepository>();
        }
    }
}
