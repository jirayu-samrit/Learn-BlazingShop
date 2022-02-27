using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazingShop.Shared
{
	public class cmProduct
	{
		public int nId { get; set; }
		public string tTitle { get; set; }
		public string tDescription { get; set; }
		public string tImg { get; set; } = "https://via.placeholder.com/300";
		public decimal cPrice { get; set; }
		public decimal cBasePrice { get; set; }
		public bool bIsPublic { get; set; }
		public bool bIsDeleted { get; set; }
		public cmCategory oCategory { get; set; }
		public int nCategoryId { get; set; }
		public DateTime dDateCreate { get; set; } = DateTime.Now;
		public DateTime dDateUpdate { get; set; } = DateTime.Now;
	}
}
