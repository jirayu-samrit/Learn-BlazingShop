using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazingShop.Shared
{
	public class cmCategory
	{
		public int nID { get; set; }
		public string tName { get; set; }
		public string tUrl { get; set; }
		public string tIcon { get; set; }
		public List<cmProduct> aoProducts { get; set; }
	}
}
