using BotanikBambu.Business.Abstract;
using BotanikBambu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BotanikBambu.Models;

using BotanikBambu.Repository.Shared.Absract;
using Microsoft.Extensions.DependencyInjection;
namespace BotanikBambu.Business.Concrete
{
    public class CustomerİnfoService : ICustomerİnfoService
    {
        private readonly IRepository<Customerİnfo> _customerRepository;

        public CustomerİnfoService(IRepository<Customerİnfo> customerRepository)
        {
            _customerRepository = customerRepository;
        }




        public Customerİnfo Add(Customerİnfo customerInfo)
        {
            return _customerRepository.Add(customerInfo);
        }



        public IQueryable<Customerİnfo> GetAll(int customerId)
        {
            return _customerRepository.GetAll();
        }

        public Customerİnfo Update(Customerİnfo customerInfo)
        {
            return _customerRepository.Update(customerInfo);
        }

        public bool Delete(int id)
        {
            return _customerRepository.Delete(id) is object;
        }



        public Customerİnfo GetById(int customerInfo)
        {
            throw new NotImplementedException();
        }


    }
}
