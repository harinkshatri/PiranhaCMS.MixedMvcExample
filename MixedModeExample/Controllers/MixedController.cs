using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MixedModeExample.Controllers
{
    public class MixedController : Piranha.Mvc.SinglePageController
    {
        //
        // GET: /Mixed/

        public ActionResult Index()
        {
			var model = new Models.MixedModel() { 
				Now = DateTime.Now,
				CMSData = this.GetModel("mixed")
			};
			return View(model);
        }

    }
}
