using Matrix.Services.Concrete;
using Matrix.Services.Interfaces;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix.Services.DependencyInjection
{
    public class SimpleInjectorServicesInitializer
    {
        public static void InitializeContainer(Container container)
        {
            container.Register(() => new ServiceFactory(container));

            container.Register<ICryptographyService, CryptographyService>();
            container.Register<IRoomService, RoomService>();
            container.Register<IUserService, UserService>();
        }
    }
}
