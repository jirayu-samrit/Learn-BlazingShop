using BlazingShop.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazingShop.Client.Services.CategoryService
{
	public interface iCategoryService
	{
		List<cmCategory> aoCategories { get; set; }
		Task LoadCategories();
	}
}
