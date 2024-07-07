using BotanikBambu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotanikBambu.Business.Abstract
{
    public interface ITruckerInfoServices
    {
        IQueryable<Truckerİnfo> GetAll(int truckerId);
        Truckerİnfo Add(Truckerİnfo truckerİnfo);
        bool Delete(int truckerId);
        Truckerİnfo Update(Truckerİnfo truckerİnfo);

    }
}
