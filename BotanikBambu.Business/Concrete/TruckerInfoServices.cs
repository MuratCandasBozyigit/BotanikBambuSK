using BotanikBambu.Business.Abstract;
using BotanikBambu.Models;
using BotanikBambu.Repository.Shared.Absract;
using Org.BouncyCastle.Asn1.X9;
using System.Linq;

namespace BotanikBambu.Business.Concrete
{
    public class TruckerInfoServices : ITruckerInfoServices
    {
        private readonly IRepository<Truckerİnfo> _repository;

        public TruckerInfoServices(IRepository<Truckerİnfo> repository)
        {
            _repository = repository;
        }

        public Truckerİnfo Add(Truckerİnfo truckerİnfo)
        {
            return _repository.Add(truckerİnfo);

        }

        public bool Delete(int truckerId)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Truckerİnfo> GetAll(int truckerId)
        {
            throw new NotImplementedException();
        }

        public Truckerİnfo Update(Truckerİnfo truckerİnfo)
        {
            return _repository.Update(truckerİnfo);

        }
    }
}
