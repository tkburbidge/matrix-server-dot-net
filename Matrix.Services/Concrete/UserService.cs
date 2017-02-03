using Matrix.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Matrix.Domain.DependencyInjection;
using Matrix.Domain.Models.Database;
using Matrix.Common.Errors;
using System.Security.Cryptography;
using Matrix.Services.DependencyInjection;
using Matrix.Common.Utilities;

namespace Matrix.Services.Concrete
{
    public class UserService : Service, IUserService
    {
        public UserService(ServiceFactory serviceFactory, RepositoryFactory repositoryFactory) : base(serviceFactory, repositoryFactory)
        {
        }

        public User RegisterUser(string username, string password)
        {
            if(this.UsernameIsInUse(username))
            {
                throw MatrixException.UserInUse;
            }

            User user = new User()
            {
                Username = username,
                PasswordHash = this.serviceFactory.CryptographyService.HashPassword(password),
                DateCreated = DateTime.UtcNow,
                IsAdmin = false
            };

            this.repositoryFactory.UserRepository.Add(user);

            return user;
        }

        public bool UsernameIsInUse(string username)
        {
            return (from u in this.repositoryFactory.UserRepository.FindAll()
                    where u.Username == username
                    select u).Any();
        }

        public User Login(string usernameOrId, string password)
        {
            MatrixId userId = new MatrixId(usernameOrId, "chat.myresman.com");

            var user = (from u in this.repositoryFactory.UserRepository.FindAll()
                        where u.Username == userId.Username
                        select u).FirstOrDefault();


            if (user == null ||
                this.serviceFactory.CryptographyService.CheckPassword(user.PasswordHash, password) == false)
            {
                throw MatrixException.Forbidden;
            }

            return user;
        }

    }
}
