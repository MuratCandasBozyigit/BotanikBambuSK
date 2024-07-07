using BotanikBambu.Business.Concrete;
using BotanikBambu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BotanikBambu.Business.Abstract
{
    public interface ICustomerİnfoService
    {
        IQueryable<Customerİnfo> GetAll(int customerİnfo);
        Customerİnfo Add(Customerİnfo customerİnfo);
        bool Delete(int customerId);
        Customerİnfo Update(Customerİnfo customerİnfo);

        Customerİnfo GetById(int customerId);
    }
}
