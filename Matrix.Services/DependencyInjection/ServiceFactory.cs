using Matrix.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix.Services.DependencyInjection
{
    public class ServiceFactory
    {
        private IServiceProvider serviceProvider;

        public ServiceFactory(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        public ICryptographyService CryptographyService { get { return (ICryptographyService)this.serviceProvider.GetService(typeof(ICryptographyService)); } }
        public IRoomService RoomService { get { return (IRoomService)this.serviceProvider.GetService(typeof(IRoomService)); } }
        public IUserService UserService { get { return (IUserService)this.serviceProvider.GetService(typeof(IUserService)); } }
    }
}
