using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.web.Data
{
    using Entities;

    public interface IProductRepository : IGenericRepository<Product>
    {

        IQueryable GetAllWithUsers();

    }

}
