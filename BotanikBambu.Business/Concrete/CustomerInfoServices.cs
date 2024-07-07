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
using BotanikBambu.Models;
using BotanikBambu.Repository.Shared.Absract;

namespace BotanikBambu.Business.Concrete
{
    public class CustomerİnfoService : ICustomerİnfoService
    {
        private readonly IRepository<Customerİnfo> _repository;

        public CustomerİnfoService(IRepository<Customerİnfo> repository)
        {
            _repository = repository;
        }

        public Customerİnfo Add(Customerİnfo category)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int categoryId)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Customerİnfo> GetAll(int customerId)
        {
            throw new NotImplementedException();
        }

        public Customerİnfo GetById(int categoryId)
        {
            throw new NotImplementedException();
        }

        public Customerİnfo Update(Customerİnfo category)
        {
            throw new NotImplementedException();
        }

        // Implement ICustomerİnfoService methods...
    }

   
}
