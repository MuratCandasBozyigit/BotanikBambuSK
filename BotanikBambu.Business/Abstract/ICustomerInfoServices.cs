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
        IQueryable<Customerİnfo> GetAll(int customerId);
        Customerİnfo Add(Customerİnfo category);
        bool Delete(int categoryId);
        Customerİnfo Update(Customerİnfo category);

        Customerİnfo GetById(int categoryId);
    }
}
