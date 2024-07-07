using BotanikBambu.Business.Abstract;
using BotanikBambu.Models;
using Microsoft.AspNetCore.Mvc;

namespace BotanikBambu.Web.Areas.Admin.Controllers
{
    public class KamyoncuController : Controller
    {
        private readonly ITruckerInfoServices _services;

        public KamyoncuController(ITruckerInfoServices services)
        {
            _services = services;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetAll(int truckerId)
        {
            return Json(new { data = _services.GetAll(truckerId) });
        }

        public IActionResult Add(Truckerİnfo truckerİnfo)
        {
            return Ok(_services.Add(truckerİnfo));
        }
        public IActionResult Update(Truckerİnfo truckerİnfo)
        {
            return Ok(_services.Update(truckerİnfo));
        }
        public IActionResult Delete(int id)
        {
            return Ok(_services.Delete(id));
        }
    }
}
