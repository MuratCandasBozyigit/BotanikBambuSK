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
        private readonly IRepository<Orderİnfo> _orderInfoServices;

        public OrderInfoServices(IRepository<Orderİnfo> orderInfoServices)
        {
            _orderInfoServices = orderInfoServices;
        }

        public Orderİnfo Add(Orderİnfo orderInfo)
        {
            return _orderInfoServices.Add(orderInfo);
            
        }

        public bool Delete(int orderID)
        {
            return _orderInfoServices.Delete(orderID) is object;
        }

        public IQueryable<Orderİnfo> GetAll(int orderId)
        {
            return _orderInfoServices.GetAll();
          
        }

        public Orderİnfo Update(Orderİnfo orderInfo)
        {
            return _orderInfoServices.Update(orderInfo);
        }

       
    }
}
