using BotanikBambu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotanikBambu.Business.Abstract
{
    public interface IOrderInfoServices
    {
        IQueryable<Orderİnfo> GetAll(int orderId);
        Orderİnfo Add(Orderİnfo orderInfo);
        bool Delete(int orderID);
        Orderİnfo Update(Orderİnfo orderInfo);
      

    }
}
