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
        IQueryable<Truckerİnfo> GetAll(int orderId);
        Truckerİnfo Add(Truckerİnfo orderInfo);
        bool Delete(int orderID);
        Truckerİnfo Update(Truckerİnfo orderInfo);
      

    }
}
