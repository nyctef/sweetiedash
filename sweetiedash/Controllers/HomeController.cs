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
            var jsonResponse = await new HttpClient().GetAsync("http://nyc-02.cloudapp.net");
            var json = await jsonResponse.Content.ReadAsStringAsync();

            ViewBag.Model = JObject.Parse(json);
            return View();
        }
    }
}