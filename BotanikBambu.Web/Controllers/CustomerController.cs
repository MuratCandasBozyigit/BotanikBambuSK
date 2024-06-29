using Microsoft.AspNetCore.Mvc;
using BotanikBambu.Data;
using BotanikBambu.Models;
using BotanikBambu.Business.Concrete;
using BotanikBambu.Business.Abstract;
using System.ComponentModel.Design;
namespace BotanikBambu.Web.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerİnfoService _customer;

        public CustomerController(ICustomerİnfoService customer)
        {
            _customer = customer;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add(Customerİnfo customer)
        {
         
            return Ok(_customer.Add(customer));
        }
        public IActionResult Update(Customerİnfo customer)
        {
           
            return Ok(_customer.Update(customer));
        }


        public IActionResult GetAll(int customerId)
        {

            return Json(new { data = _customer.GetAll(customerId) });
        }


        public IActionResult Delete(int id)
        {
           
            return Ok(_customer.Delete(id) is object);
        }
    }
}
