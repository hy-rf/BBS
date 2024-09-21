using BBS.Data;
using BBS.Models;
using Microsoft.AspNetCore.Mvc;

namespace BBS.Controllers
{
    public class Test(AppDbContext ctx) : Controller
    {
        [Route("Test")]
        public JsonResult Index()
        {
            var a = ctx.Tag.Count();
            Console.WriteLine(a);
            return Json(new JsonBody
            {
                Success = false,
                Message = a.ToString()
            });
        }
    }
}