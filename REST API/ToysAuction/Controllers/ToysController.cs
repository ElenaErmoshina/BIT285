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
    public class ToysController : ApiController
    {
        private IRepository repo;
        public ToysController()
        {
            this.repo = new Repository();
        }

        public IEnumerable<Toy> Get()
        {
            return this.repo.GetToys();
        }

        public Toy Post(Toy toy)
        {
            this.repo.CreateToy(toy);
            return toy;
        }
    }

    

}
