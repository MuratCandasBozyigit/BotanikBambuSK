using BotanikBambu.Data;
using BotanikBambu.Models;
using BotanikBambu.Repository.Shared.Absract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BotanikBambu.Repository.Shared.Concrete
{
    public class Repository<T> : IRepository<T> where T : BaseModel
    {
   private readonly ApplicationDbContext _context;
        private readonly DbSet<T> _dbSet;

        public Repository(DbSet<T> dbSet, ApplicationDbContext context)
        {
            _dbSet = dbSet;
            _context = context;
        }


        public T Add(T entity)
        {
            try
            {
                _dbSet.Add(entity);
             Save();
                return entity;
            }
            catch
            {
                return entity;
            }
        }

        public List<T> AddRange(List<T> entities)
        {
            _dbSet.AddRange(entities);
            Save();
            return entities;
        }

        public void Delete(int id)
        {
            T entity = _dbSet.Find(id);
            entity.IsDeleted = true;

            Update(entity);
        }

        public IQueryable<T> GetAll()
        {
            return _dbSet.Where(x => !x.IsDeleted);
        }

        public IQueryable<T> GetAll(Expression<Func<T, bool>> predicate)
        {
            return GetAll().Where(predicate);
        }

        public T GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public T GetFirstOrDefault(Expression<Func<T, bool>> predicate)
        {
            return _dbSet.FirstOrDefault(predicate);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public T Update(T entity)
        {
            _dbSet.Update(entity);
            Save();
            return entity;
        }
    }
}
