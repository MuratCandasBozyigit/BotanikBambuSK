using BotanikBambu.Business.Abstract;
using BotanikBambu.Models;
using Microsoft.AspNetCore.Mvc;

namespace BotanikBambu.Web.Controllers
{
    public class SiparisController : Controller
    {
        private readonly IOrderInfoServices _orderInfoServices;

        public SiparisController(IOrderInfoServices orderInfoServices)
        {
            _orderInfoServices = orderInfoServices;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetAll(int orderId)
        {
            return Json(new { data = _orderInfoServices.GetAll(orderId) });
        }

        public IActionResult Add(Orderİnfo orderInfo)
        {
            return Ok(_orderInfoServices.Add(orderInfo));

        }

        public IActionResult Update(Orderİnfo orderInfo)
        {
            return Ok(_orderInfoServices.Update(orderInfo));
        }

        public IActionResult Delete(int orderId)
        {
            return Ok(Delete(orderId));
        }
    }
}
