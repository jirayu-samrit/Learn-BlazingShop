using BlazingShop.Server.Services.CategoryService;
using BlazingShop.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazingShop.Server.Controllers
{
	[Route("api/Category")]
	[ApiController]
	public class ctrCategoryController : ControllerBase
	{
		private readonly iCategoryService _oCategoryService;

		public ctrCategoryController(iCategoryService poCategoryService)
		{
			_oCategoryService = poCategoryService;
		}


		[HttpGet]
		public async Task<ActionResult<List<cmCategory>>> GetCategories()
		{
			return Ok(await _oCategoryService.GetCategories());
		}
	}
}
