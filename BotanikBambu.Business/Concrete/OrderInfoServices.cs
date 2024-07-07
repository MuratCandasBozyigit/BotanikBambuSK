using BotanikBambu.Business.Abstract;
using BotanikBambu.Models;
using BotanikBambu.Repository.Shared.Absract;
using Mysqlx;
using Org.BouncyCastle.Asn1.X9;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotanikBambu.Business.Concrete
{
    public class OrderInfoServices : IOrderInfoServices
    {
        private readonly IRepository<Truckerİnfo> _repository;

        public OrderInfoServices(IRepository<Truckerİnfo> repository)
        {
            _repository = repository;
        }


        public Truckerİnfo Add(Truckerİnfo orderInfo)
        {
            return _repository.Add(orderInfo);
            
        }

        public bool Delete(int orderID)
        {
            return _repository.Delete(orderID) is object;
        }

        public IQueryable<Truckerİnfo> GetAll(int orderId)
        {
            return _repository.GetAll();
          
        }

        public Truckerİnfo Update(Truckerİnfo orderInfo)
        {
            return _repository.Update(orderInfo);
        }

       
    }
}
