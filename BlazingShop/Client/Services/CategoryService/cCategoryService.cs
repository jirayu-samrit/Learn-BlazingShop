using BlazingShop.Shared;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BlazingShop.Client.Services.CategoryService
{
	public class cCategoryService : iCategoryService
	{
		public List<cmCategory> aoCategories { get; set; } = new List<cmCategory>();
		private HttpClient _oHttpClient;


		public cCategoryService(HttpClient poHttp)
		{
			_oHttpClient = poHttp;
		}

		public async Task LoadCategories()
		{
			aoCategories = await _oHttpClient.GetFromJsonAsync<List<cmCategory>>("api/Category");
		}
	}
}
