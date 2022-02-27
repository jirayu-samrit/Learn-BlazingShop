using BlazingShop.Server.Services.ProductService;
using BlazingShop.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazingShop.Server.Controllers
{
	[Route("api/Product")]
	[ApiController]
	public class ctrProductController : ControllerBase
	{
		private readonly iProductService _oProductService;

		public ctrProductController(iProductService poProductService)
		{
			_oProductService = poProductService;
		}

		[HttpGet]
		public async Task<ActionResult<List<cmProduct>>> GetProducts()
		{
			return Ok(await _oProductService.GetProducts());
		}

		[HttpGet("ByCategory/{ptCategoryUrl}")]
		public async Task<ActionResult<List<cmProduct>>> GetProducts(string ptCategoryUrl)
		{
			return Ok(await _oProductService.GetProductByCategory(ptCategoryUrl));
		}
		[HttpGet("ById/{pnProductId}")]
		public async Task<ActionResult<cmProduct>> GetProducts(int pnProductId)
		{
			return Ok(await _oProductService.GetProductById(pnProductId));
		}
	}
}
