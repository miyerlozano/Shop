using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shop.web.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.web.Controllers.API
{
    [Route("api/[Controller]")]
	[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]

	public class ProductsController : Controller
	{
		private readonly IProductRepository productRepository;

		public ProductsController(IProductRepository productRepository)
		{
			this.productRepository = productRepository;
		}

		[HttpGet]
		public IActionResult GetProducts()
		{
			return this.Ok(this.productRepository.GetAllWithUsers());
		}
	}


}
