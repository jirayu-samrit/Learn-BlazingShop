using BlazingShop.Shared;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BlazingShop.Client.Services.ProductService
{
	public class cProductService : iProductService
	{
		public List<cmProduct> aoProducts { get; set; } = new List<cmProduct>();
		private HttpClient _oHttpClient;

		public event Action OnChange;

		public cProductService(HttpClient poHttpClient)
		{
			_oHttpClient = poHttpClient;
		}


		public async Task LoadProducts(string ptCategoryUrl = null)
		{
			if(String.IsNullOrEmpty(ptCategoryUrl))
			{
				aoProducts = await _oHttpClient.GetFromJsonAsync<List<cmProduct>>($"api/Product");

			}
			else
			{
				aoProducts = await _oHttpClient.GetFromJsonAsync<List<cmProduct>>($"api/Product/ByCategory/{ptCategoryUrl}");
			}
			OnChange.Invoke();
		}

		public async Task<cmProduct> LoadProducts(int pnProductId)
		{
			return await _oHttpClient.GetFromJsonAsync<cmProduct>($"api/Product/ById/{pnProductId}");
		}
	}
}
