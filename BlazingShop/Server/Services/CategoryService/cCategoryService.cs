using BlazingShop.Shared;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazingShop.Server.Services.CategoryService
{
	public class cCategoryService : iCategoryService
	{
		public List<cmCategory> aoCategories { get; set; } = new List<cmCategory>()
			{
				new cmCategory(){ nID=1, tName="Book", tUrl="books", tIcon="book" },
				new cmCategory(){ nID=2, tName="Video Games", tUrl="video-games", tIcon="aperture" },
				new cmCategory(){ nID=3, tName="Toys", tUrl="toys", tIcon="basket" },
			};

		public async Task<List<cmCategory>> GetCategories()
		{
			return aoCategories;
		}

		public async Task<cmCategory> GetCategoriesByUrl(string ptCategoryUrl)
		{
			return aoCategories.FirstOrDefault(c => c.tUrl.ToLower() == ptCategoryUrl.ToLower());
		}
	}
}
