using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MixedModeExample.Models
{
	public class MixedModel
	{
		public DateTime Now { get; set; }
		public Piranha.Models.PageModel CMSData { get; set; }
	}
}