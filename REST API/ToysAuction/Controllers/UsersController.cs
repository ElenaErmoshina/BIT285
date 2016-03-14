using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ToysAuction.Models;
using ToysAuction.DataAccess;

namespace ToysAuction.Controllers
{
    public class UsersController : ApiController
    {
        private IRepository repo;

        public UsersController()
        {
            repo = new Repository();
        }

        public List<User> Get()
        {
            return repo.GetUsers();
        }

        public User Post(User user)
        {
            var created = this.repo.CreateUser(user);
            return created;
        }
    }
}
