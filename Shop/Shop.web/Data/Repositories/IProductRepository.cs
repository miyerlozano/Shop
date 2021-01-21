using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.web.Data
{
    using Entities;
    using Microsoft.AspNetCore.Mvc.Rendering;

    public interface IProductRepository : IGenericRepository<Product>
    {

        IQueryable GetAllWithUsers();

        IEnumerable<SelectListItem> GetComboProducts();

    }

}
