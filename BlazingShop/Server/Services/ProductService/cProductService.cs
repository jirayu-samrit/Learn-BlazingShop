using BlazingShop.Server.Services.CategoryService;
using BlazingShop.Shared;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazingShop.Server.Services.ProductService
{
	public class cProductService : iProductService
	{
		private readonly iCategoryService _oCategoryService;

		public List<cmProduct> aoProducts { get; set; } = new List<cmProduct>()
			{
				new cmProduct()
				{
					nId = 1,
					nCategoryId = 1,
					tTitle = "ARCHITECTURAL DIGEST (M-USA)",
					tDescription = "Architectural Digest is the ultimate guide to exquisite architecture and design. Take a tour of the world's most beautiful homes through striking photography and fascinating prose .",
					tImg ="https://www.asiabooks.com/media/catalog/product/cache/a5ac216be58c0cbce1cb04612ece96dc/a/r/architectural_digest_m-usa_.jpg",
					cPrice=4944m,
					cBasePrice=6100m,
				},
				new cmProduct()
				{
					nId = 2,
					nCategoryId = 1,
					tTitle = "ELLE DECORATION (M-UK)",
					tDescription = "ELLE Decoration magazine is the ultimate guide to decorating and design and a subscription to ELLE Decoration magazine is the indispensable must-have source for anyone who wants to create a more beautiful life.",
					tImg ="https://www.asiabooks.com/media/catalog/product/cache/a5ac216be58c0cbce1cb04612ece96dc/e/l/elle_decoration_m-uk_.jpg",
					cPrice=4752m,
					cBasePrice=5940.00m,
				},
				new cmProduct()
				{
					nId = 3,
					nCategoryId = 1,
					tTitle = "WALL PAPER (M-UK)",
					tDescription = "Features the foremost of international design, art and lifestyle, offering limited-edition covers designed by premier artists. Wallpaper* magazine provides its readers with the latest in modern design from around the globe, including fashion, travel, interiors and cars.",
					tImg ="https://www.asiabooks.com/media/catalog/product/cache/a5ac216be58c0cbce1cb04612ece96dc/w/a/wall_paper_uk__1.jpg",
					cPrice=6576m,
					cBasePrice=8220m,
				},
				new cmProduct()
				{
					nId = 4,
					nCategoryId = 2,
					tTitle = "Hades PS4 Version",
					tDescription = "Hades is a god-like rogue-like dungeon crawler that combines the best aspects of Supergiant’s critically acclaimed titles, including the fast-paced action of Bastion, the rich atmosphere and depth of Transistor, and the character-driven storytelling of Pyre.",
					tImg ="https://www.gameshopconceptstore.com/wp-content/uploads/2021/06/hades-ps4-570x570.jpg",
					cPrice=1150m,
					cBasePrice=1150m,
				},
				new cmProduct()
				{
					nId = 5,
					nCategoryId = 2,
					tTitle = "Biomutant-PS4",
					tDescription = "BIOMUTANT® is an open-world, post-apocalyptic Kung-Fu fable RPG, with a unique martial arts styled combat system allowing you to mix melee, shooting and mutant ability action.",
					tImg ="https://www.gameshopconceptstore.com/wp-content/uploads/2021/05/Biomutant-SE_PS4-570x570.jpg",
					cPrice=1890.00m,
					cBasePrice=1890.00m,
				},
				new cmProduct()
				{
					nId = 6,
					nCategoryId = 2,
					tTitle = "PS4 NBA2K21-Mamba Forever Edition",
					tDescription = "PS4 NBA2K21-Mamba Forever Edition",
					tImg ="https://www.gameshopconceptstore.com/wp-content/uploads/2020/07/ps4-mamba-570x570.jpg",
					cPrice=3400m,
					cBasePrice=3400m,
				},
				new cmProduct()
				{
					nId = 7,
					nCategoryId = 3,
					tTitle = "DEMON SLAYER NICHIRIN SWORD KAMADO TANJIRO：Hinokamikagura",
					tDescription = "DEMON SLAYER NICHIRIN SWORD KAMADO TANJIRO：Hinokamikagura",
					tImg ="https://www.dreamtoy.co.th/media/catalog/product/cache/16/image/9df78eab33525d08d6e5fb8d27136e95/d/x/dxnichirinto-hinokami-juchu_01.jpg",
					cPrice=2190m,
					cBasePrice=2190m,
				},
				new cmProduct()
				{
					nId = 8,
					nCategoryId = 3,
					tTitle = "BUSTERCALL DEVILISH NAMI",
					tDescription = "BUSTERCALL DEVILISH NAMI",
					tImg ="https://www.dreamtoy.co.th/media/catalog/product/cache/16/thumbnail/9df78eab33525d08d6e5fb8d27136e95/p/-/p-8017346-1.jpg",
					cPrice=2745m,
					cBasePrice=2745m,
				},
				new cmProduct()
				{
					nId = 9,
					nCategoryId = 3,
					tTitle = "G.E.M. SERIES  EVANGELION： 3.0+1.0 THRICE UPON A TIME REI AYANAMI",
					tDescription = "G.E.M. SERIES  EVANGELION： 3.0+1.0 THRICE UPON A TIME REI AYANAMI",
					tImg ="https://www.dreamtoy.co.th/media/catalog/product/cache/16/image/9df78eab33525d08d6e5fb8d27136e95/p/-/p-6083344_1.jpg",
					cPrice=6130m,
					cBasePrice=6130m,
				}
			};

		public cProductService(iCategoryService poCategoryService)
		{
			_oCategoryService = poCategoryService;
		}
		public async Task<List<cmProduct>> GetProducts()
		{
			return aoProducts;
		}
		public async Task<List<cmProduct>> GetProductByCategory(string poCategoryUrl)
		{
			cmCategory oCategory = await _oCategoryService.GetCategoriesByUrl(poCategoryUrl);
			return aoProducts.Where(p=>p.nCategoryId == oCategory.nID).ToList();
		}

		public async Task<cmProduct> GetProductById(int pnId)
		{
			return aoProducts.FirstOrDefault(p => p.nId == pnId);
		}
	}
}
