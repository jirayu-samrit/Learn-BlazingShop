using BlazingShop.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazingShop.Server.Services.CategoryService
{
	public interface iCategoryService
	{
		Task<List<cmCategory>> GetCategories();
		Task<cmCategory> GetCategoriesByUrl(string ptCategoryUrl);
	}
}
