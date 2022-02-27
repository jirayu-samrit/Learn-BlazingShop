using BlazingShop.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazingShop.Server.Services.ProductService
{
	public interface iProductService
	{
		Task<List<cmProduct>> GetProducts();
		Task<List<cmProduct>> GetProductByCategory(string poCategoryUrl);
		Task<cmProduct> GetProductById(int pnId);
	}
}
