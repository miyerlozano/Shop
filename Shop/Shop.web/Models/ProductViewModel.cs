using Shop.web.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.web.Models
{
    public class ProductViewModel: Product
    {
        [Display(Name = "Image")]
        public IFormFile ImageFile { get; set; }


    }
}
