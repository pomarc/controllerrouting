using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Specialization.Controllers
{
    public class SpecializedHomeController : Controller
    {
        [Route("Home/ListaCitta")]
        [HttpGet]
        public ActionResult Bar()
        {
            var c = new List<string>();
            c.Add("stoccarda");
            c.Add("stoffredda");
            c.Add("stoccafisso");
            
            return new JsonResult() { JsonRequestBehavior = JsonRequestBehavior.AllowGet,Data=c };
        }


        [Route("Home/ListaCani")]
        [HttpGet]
        public ActionResult  Cani()
        {
            var c = new List<string>();
            c.Add("stoccarda");
            c.Add("stoffredda");
            c.Add("stoccafisso");
            c.Add("stoccazzo");
            return new ContentResult() { Content = c.ToString() }  ;
        }
    }
}
