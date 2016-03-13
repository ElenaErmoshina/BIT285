using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToysAuction.Models;

namespace ToysAuction.DataAccess
{
    public interface IRepository
    {
        List<Toy> GetToys();
    }
}
