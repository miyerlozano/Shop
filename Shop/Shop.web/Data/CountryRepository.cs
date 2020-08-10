using Shop.web.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.web.Data
{
    public class CountryRepository : GenericRepository<Country>, ICountryRepository
	{
		public CountryRepository(DataContext context) : base(context)
		{
		}
	}
}
