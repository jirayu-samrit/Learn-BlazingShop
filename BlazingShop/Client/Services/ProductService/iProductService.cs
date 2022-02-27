using BlazingShop.Shared;
using System.Collections.Generic;

namespace BlazingShop.Client.Services.ProductService
{
	public interface iProductService
	{
		List<cmProduct> aoProducts { get; set; }
		void LoadProducts();
	}
}
