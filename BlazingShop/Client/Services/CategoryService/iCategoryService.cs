using BlazingShop.Shared;
using System.Collections.Generic;

namespace BlazingShop.Client.Services.CategoryService
{
	public interface iCategoryService
	{
		List<cmCategory> aoCategories { get; set; }
		void LoadCategories();
	}
}
