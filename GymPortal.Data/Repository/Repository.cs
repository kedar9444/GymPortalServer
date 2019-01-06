using GymPortal.Data.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using GymPortal.Data.Configuration;

namespace GymPortal.Data.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        //_Context is base class object used in all derivesd classes
        protected readonly GymPortalEntities _Context = null;

        //public Repository(GymPortalEntities context)
        //{
        //    _Context = new GymPortalEntities();
        //}

        public Repository()
        {
            _Context = ContextConfig.ConfigureContext();
        }

        public TEntity Add(TEntity entity)
        {
            var user = _Context.Set<TEntity>().Add(entity);
            ContextConfig.SaveChanges();
            return user;
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            _Context.Set<TEntity>().AddRange(entities);
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return _Context.Set<TEntity>().Where(predicate);
        }

        public TEntity Get(int id)
        {
            return _Context.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _Context.Set<TEntity>().ToList();
        }

        public int GetCount()
        {
            return _Context.Set<TEntity>().Count();
        }

        public void Remove(TEntity entity)
        {
            _Context.Set<TEntity>().Remove(entity);
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            _Context.Set<TEntity>().RemoveRange(entities);
        }

        public TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate)
        {
            return _Context.Set<TEntity>().SingleOrDefault(predicate);
        }

        //public int Add(TEntity entity)
        //{
        //    _Context.Set<TEntity>().Add(entity);
        //}

        //public void Add(TEntity entity)
        //{
        //    _Context.Set<TEntity>().Add(entity);
        //}
    }
}
