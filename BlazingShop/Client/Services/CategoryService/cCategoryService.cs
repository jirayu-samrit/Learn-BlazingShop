using BlazingShop.Shared;
using System.Collections.Generic;

namespace BlazingShop.Client.Services.CategoryService
{
	public class cCategoryService : iCategoryService
	{
		public List<cmCategory> aoCategories { get; set; } = new List<cmCategory>();

		public void LoadCategories()
		{
			aoCategories = new List<cmCategory>()
			{
				new cmCategory(){ nID=1, tName="Book", tUrl="books", tIcon="book" },
				new cmCategory(){ nID=2, tName="Video Games", tUrl="video-games", tIcon="aperture" },
				new cmCategory(){ nID=3, tName="Toys", tUrl="toys", tIcon="basket" },
			};
		}
	}
}
