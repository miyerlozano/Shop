

namespace Shop.web.Data.Entities
{
    using Microsoft.CodeAnalysis.Operations;
    using System;
	using System.ComponentModel.DataAnnotations;

	public class Product:IEntity
	{
		public int Id { get; set; }

		[Required]
		[MaxLength(50,ErrorMessage =" El campo {0} debe ser menor {1} caracteres")]
		public string Name { get; set; }

		[DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
		public decimal Price { get; set; }

		[Display(Name = "Image")]
		public string ImageUrl { get; set; }

		[Display(Name = "Last Purchase")]
		[DisplayFormat(DataFormatString = "{0:dd/mm/yyyy}", ApplyFormatInEditMode = true)]
		public DateTime? LastPurchase { get; set; }

		[Display(Name = "Last Sale")]
		[DisplayFormat(DataFormatString = "{0:dd/mm/yyyy}", ApplyFormatInEditMode = true)]
		public DateTime? LastSale { get; set; }

		[Display(Name = "Is Availabe?")]
		public bool IsAvailabe { get; set; }

		[DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = false)]
		public double Stock { get; set; }


        public User User { get; set; }

		public string ImageFullPath {
			get
			{ 
			
				if(string.IsNullOrEmpty(this.ImageUrl))
                {

					return null;
                }

				return $"https://shopweb20.azurewebsites.net{this.ImageUrl.Substring(1)}";

			}
		
		}

    }


}
