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
    public class ColorsController : ApiController
    {
        private IRepository repo;

        public ColorsController()
        {
            repo = new Repository();
        }

        public List<Color> Get()
        {
            return repo.GetColors();
        }

        public Color Post(Color color)
        {
            var created = this.repo.CreateColor(color);
            return created;
        }
    }
}
