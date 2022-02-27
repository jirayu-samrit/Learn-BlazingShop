using BlazingShop.Shared;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazingShop.Client.Services.ProductService
{
	public interface iProductService
	{
		event Action OnChange;
		List<cmProduct> aoProducts { get; set; }
		Task LoadProducts(string ptCategoryUrl = null);
		Task<cmProduct> LoadProducts(int pnProductId);
	}
}
