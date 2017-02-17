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

        public IAccessTokenRepository AccessTokenRepository { get { return (IAccessTokenRepository)this.serviceProvider.GetService(typeof(IAccessTokenRepository)); } }
        public IEventRepository EventRepository { get { return (IEventRepository)this.serviceProvider.GetService(typeof(IEventRepository)); } }
        public IRoomRepository RoomRepository { get { return (IRoomRepository)this.serviceProvider.GetService(typeof(IRoomRepository)); } }
        public IRoomAliasRepository RoomAliasRepository { get { return (IRoomAliasRepository)this.serviceProvider.GetService(typeof(IRoomAliasRepository)); } }
        public IUserRepository UserRepository { get { return (IUserRepository)this.serviceProvider.GetService(typeof(IUserRepository)); } }
    }
}
