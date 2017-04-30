using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace sweetiedash.Controllers
{
    public class HomeController : Controller
    {
        public async Task<ActionResult> Index()
        {
            var target = "http://nyc-06.uksouth.cloudapp.azure.com/";
            var jsonResponse = await new HttpClient().GetAsync(target);
            var json = await jsonResponse.Content.ReadAsStringAsync();

            ViewBag.Model = JObject.Parse(json);
            ViewBag.Target = target;
            return View();
        }
    }
}
